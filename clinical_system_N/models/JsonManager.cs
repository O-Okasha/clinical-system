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


        private string LoadJson(JsonType enumType, string patientID)
        {
            string DataPath = Path.Combine(Path.Combine(GlobalVariables.PathToPatients, patientID), "Data");
            if (enumType == JsonType.History)
            {
                using (StreamReader r = new StreamReader(Path.Combine(DataPath, "History.json"))) 
                {
                    json = r.ReadToEnd();
                }
            }
            if (enumType == JsonType.MetaData)
            {
                using (StreamReader r = new StreamReader(Path.Combine(DataPath, "MetaData.json")))
                {
                    json = r.ReadToEnd();
                }
            }
            if (enumType == JsonType.Prescriptions)
            {
                using (StreamReader r = new StreamReader(Path.Combine(DataPath, "Prescriptions.json")))
                {
                    json = r.ReadToEnd();
                }
            }
            if (enumType == JsonType.Visits)
            {
                using (StreamReader r = new StreamReader(Path.Combine(DataPath, "Visits.json")))
                {
                    json = r.ReadToEnd();
                }
            }
            return json;
            
        }

        public Dictionary<string, object> deserializeToDictionary(JsonType jsonType, string patientID)
        {
            string jo = LoadJson(jsonType, patientID);
            var values = JsonConvert.DeserializeObject<Dictionary<string, object>>(jo);
 //           var values2 = new Dictionary<string, object>();
//            foreach (KeyValuePair<string, object> d in values)
//            {
//                 //if (d.Value.GetType().FullName.Contains("Newtonsoft.Json.Linq.JObject"))
//                if (d.Value is JObject)
//                {
//#pragma warning disable CS8604 // Possible null reference argument.
//                    values2.Add(d.Key, deserializeToDictionary(d.Value.ToString()));
//#pragma warning restore CS8604 // Possible null reference argument.
//                }
//                else
//                {
//                    values2.Add(d.Key, d.Value);
//                }
//            }
            return values;
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
