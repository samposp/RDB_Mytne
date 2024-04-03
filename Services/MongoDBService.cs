using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace RDB_Mytne.Services
{
    public class MongoDBService
    {
        MongoClient client;
        public MongoDBService()
        {
            string connectionString = "mongodb+srv://samuelpospisil:qSWsQlzDWNZxumyl@rdb-mytne-mongo.nncfcdc.mongodb.net/?retryWrites=true&w=majority&appName=rdb-mytne-mongo";
            client = new(connectionString);

            try
            {
                var collection = client.GetDatabase("sample_mflix").GetCollection<BsonDocument>("movies");
                var filter = Builders<BsonDocument>.Filter.Eq("title", "Back to the Future");
                var document = collection.Find(filter).First();
                Console.WriteLine(document);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

        }
    }
}
