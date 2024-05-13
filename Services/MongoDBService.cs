using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Newtonsoft.Json.Linq;

namespace RDB_Mytne.Services
{
    public class MongoDBService
    {
        MongoClient dbClient;
        IMongoCollection<BsonDocument> mytneCollection;
        public MongoDBService()
        {
            //string connectionString = "mongodb+srv://samuelpospisil:qSWsQlzDWNZxumyl@rdb-mytne-mongo.nncfcdc.mongodb.net/?retryWrites=true&w=majority&appName=rdb-mytne-mongo";
            string connectionString = "mongodb://localhost:27017/";
            dbClient = new(connectionString);
            var database = dbClient.GetDatabase("RDB");
            mytneCollection = database.GetCollection<BsonDocument>("mytne");
        }

        public void InsertDocuments(List<JObject> objects)
        {
            List<BsonDocument> bson = objects.Select(x => BsonDocument.Parse(x.ToString())).ToList();
            for (int i=0; i < bson.Count(); i++)
            {
                bson[i]["prujezd"]["datum_prujezdu"] = DateTimeOffset.FromUnixTimeSeconds(bson[i]["prujezd"]["datum_prujezdu"].ToInt64()).UtcDateTime;
            }
            mytneCollection.InsertMany(bson);
        }

        public int GetKm(string spz)
        {
            var filter = Builders<BsonDocument>.Filter
                .Eq(r => r["prujezd.registrace_vozidla.vozidlo.spz"], spz);
            var documents = mytneCollection.Find(filter);
            int km = 0;
            documents.ForEachAsync(document => 
            { 
                km += document["prujezd"]["registrace_vozidla"]["ujete_km"].ToInt32();
            }).Wait();
            return km;
        }
        public string GetReport(string spz,  DateTime from, DateTime to)
        {
            string report = "";
            var filter = Builders<BsonDocument>.Filter.Gte(x => x["prujezd.datum_prujezdu"], from) &
                    Builders<BsonDocument>.Filter.Lte(x => x["prujezd.datum_prujezdu"], to) &
                    Builders<BsonDocument>.Filter.Eq(x => x["prujezd.registrace_vozidla.vozidlo.spz"], spz);
            var documents = mytneCollection.Find(filter);
            documents.ForEachAsync(document =>
            {
                report += $"datum: {document["prujezd"]["datum_prujezdu"]}, vzdalenost: {document["prujezd"]["registrace_vozidla"]["ujete_km"]}\n";
            }).Wait();

            return report;
        }
        public int  GetReportKm(string spz, DateTime from, DateTime to)
        {
            var filter = Builders<BsonDocument>.Filter.Gte(x => x["prujezd.datum_prujezdu"], from) &
                Builders<BsonDocument>.Filter.Lte(x => x["prujezd.datum_prujezdu"], to) &
                Builders<BsonDocument>.Filter.Eq(x => x["prujezd.registrace_vozidla.vozidlo.spz"], spz);
            var documents = mytneCollection.Find(filter);
            int km = 0;
            documents.ForEachAsync(document =>
            {

                km += document["prujezd"]["registrace_vozidla"]["ujete_km"].ToInt32();
            }).Wait();
            return km;
        }
    }
}
