using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace clinical_system_N.models
{
    internal class JsonManager
    {
        public string json;
        public List<object> itemList;
        public JsonType enumType;
        public void AddToJson<T,S>(string patientName, string category, Dictionary<T, S> numberNames)
        {
            enumType = JsonType.History;
        }
        public void LoadJson(JsonType EnumType, string patientID, string filePath)
        {
            if (enumType == JsonType.History)
            {

            }
            using (StreamReader r = new StreamReader(filePath + "\\" + patientID + "data.json"))
            {
                json = r.ReadToEnd();
            }
        }

        public Dictionary<string, object> deserializeToDictionary(string jo)
        {
            var values = JsonConvert.DeserializeObject<Dictionary<string, object>>(jo);
            var values2 = new Dictionary<string, object>();
            foreach (KeyValuePair<string, object> d in values)
            {
                // if (d.Value.GetType().FullName.Contains("Newtonsoft.Json.Linq.JObject"))
                if (d.Value is JObject)
                {
#pragma warning disable CS8604 // Possible null reference argument.
                    values2.Add(d.Key, deserializeToDictionary(d.Value.ToString()));
#pragma warning restore CS8604 // Possible null reference argument.
                }
                else
                {
                    values2.Add(d.Key, d.Value);
                }
            }
            return values2;
        }
    }
}
