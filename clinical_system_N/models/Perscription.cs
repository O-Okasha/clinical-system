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
        public string patientName { get; set; }
        public string DoctorName { get; set; }
        public string patientID { get; set; }
        public string DoctorID { get; set; }
        public string VisitId { get; set; }
        List<PerscribedMedicine> Medication { get; set; }
        public string SDate { get; set; }

        public Perscription(Patient patient, Doctor doctor)
        {
            Medication = new List<PerscribedMedicine>();
            Id = Guid.NewGuid().ToString();
            SDate = DateTime.Now.ToString();
            patientName = patient.info.PatientName;
            DoctorName = doctor.Name;
            patientID = patient.info.PatientId;
            DoctorID = doctor.Id;

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
            x.Add("doctor", DoctorName);
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
