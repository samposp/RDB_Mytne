using RDB_Mytne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RDB_Mytne.Services
{
    public class JsonSerializerService
    {

        public List<JObject> ReadFile(StreamReader reader)
        {
            var objects = new List<JObject>();

            using (var jsonReader = new JsonTextReader(reader))
            {
                jsonReader.SupportMultipleContent = true;

                while (jsonReader.Read())
                {
                    JObject json = (JObject)JToken.ReadFrom(jsonReader);

                    objects.Add(json);
                }
            }
            return objects;
        }
        public Vozidlo DeserializeVozidlo(JObject json)
        {
            JObject? vozidloNode = (JObject)json["prujezd"]?["registrace_vozidla"]?["vozidlo"];
            if (vozidloNode == null) { throw new ArgumentNullException($"'vozidlo' is null"); }

            Vozidlo vozidlo = new Vozidlo(
                vozidloNode["spz"].ToString(),
                json["prujezd"]?["registrace_vozidla"]?["firma"]?["ico"].ToString(),
                vozidloNode["hmotnost"].ToObject<decimal>(),
                vozidloNode["typ_vozidla"].ToString(),
                vozidloNode["emisni_trida"].ToObject<char>(),
                vozidloNode["km_sazba"].ToObject<decimal>());

            return vozidlo;
        }
        public Firma DeserializeFirma(JObject json) 
        {
            JToken? firmaNode = json["prujezd"]?["registrace_vozidla"]?["firma"];
            if (firmaNode == null) { throw new ArgumentNullException($"'firma' is null"); }

            var firma = firmaNode.ToObject<Firma>();
            if (firma == null) { throw new ArgumentNullException($"'firma' is null"); }

            return firma;
        }

        public List<Firma> DeserializeFirmy(List<JObject> objects)
        {
            return objects.Select(DeserializeFirma).ToList();
        }
        public List<Vozidlo> DeserializeVozidla(List<JObject> objects)
        {
            return objects.Select(DeserializeVozidlo).ToList();
        }
    }
}
