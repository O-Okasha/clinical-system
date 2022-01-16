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

        public void LoadJson(JsonType enumType, string patientID)
        {
            if (enumType == JsonType.History)
            {
                using (StreamReader r = new StreamReader(/*filePath + */ "\\" + patientID + "History.json"))
                {
                    json = r.ReadToEnd();
                }
            }
            if (enumType == JsonType.MetaData)
            {
                using (StreamReader r = new StreamReader(/*filePath + */ "\\" + patientID + "MetaData.json"))
                {
                    json = r.ReadToEnd();
                }
            }
            if (enumType == JsonType.Prescriptions)
            {
                using (StreamReader r = new StreamReader(/*filePath + */ "\\" + patientID + "Prescriptions.json"))
                {
                    json = r.ReadToEnd();
                }
            }
            if (enumType == JsonType.Visits)
            {
                using (StreamReader r = new StreamReader(/*filePath + */ "\\" + patientID + "Visits.json"))
                {
                    json = r.ReadToEnd();
                }
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

        /*
            Deserialize deserialize = new Deserialize();
            deserialize.LoadJson(JsonType enumType, string patientID);

#pragma warning disable CS8604 // Possible null reference argument.
            Dictionary<string, object> values = deserialize.deserializeToDictionary(deserialize.json);
#pragma warning restore CS8604 // Possible null reference argument.


            //print dictionary
            foreach (KeyValuePair<string, object> kvp in values)
            {
                //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
         */
    }
}
