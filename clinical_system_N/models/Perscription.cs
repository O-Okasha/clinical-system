using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace clinical_system_N.models
{
    internal class Perscription
    {
        public string Id { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        List<PerscribedMedicine> Medication { get; set; }
        DateTime Date { get; set; }
        public string SDate;

        public Perscription(Patient patient, Doctor doctor)
        {
            Medication = new List<PerscribedMedicine>();
            Date = DateTime.Now;
            Id = Guid.NewGuid().ToString();
            SDate = Date.ToString();
            Patient = patient;
            Doctor = doctor;

        }
        public void AddMedicine(PerscribedMedicine med) 
        { 
            Medication.Add(med); 
        }
        public void RemoveMedicine(int index) { Medication.RemoveAt(index); }

        public string GetJson() 
        {
            var dic = new Dictionary<string, object>();
            var x = new Dictionary<string, object>();
            x.Add("doctor", Doctor.Name);
            x.Add("date", SDate);
            var z = new Dictionary<string, object>();
            z.Add("meta data", x);
            z.Add("medications", Medication);
            dic.Add(Id, z);

            string json = JsonConvert.SerializeObject(dic);

            return json;
        }
    }
}
