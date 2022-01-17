using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal class Patient : Person
    {
        public PatientInformation info;
        public List<Perscription> perscriptions;
        public List<Visit> visits;

        public Patient(PatientInformation information)
        {
            info = information;

        }

        public bool ReadyPatient()
        {
            try
            {
                perscriptions = GetPrescriptions();
                visits = GetVisits();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Perscription> GetPrescriptions()
        {
            JsonManager manager = new JsonManager();

            Dictionary<string, JToken> result = manager.deserializeToDictionary(JsonType.Prescriptions, info.PatientId);
            IList<JToken> tokens = new List<JToken>();

            foreach (KeyValuePair<string, JToken> item in result)
            {
                tokens.Add(result[item.Key]);
            }
            List<Perscription> PerscriptionList = new List<Perscription>();
            foreach (var item in tokens)
            {
                PerscriptionList.Add(item.ToObject<Perscription>());
            }

            return PerscriptionList;
        }
        public List<Visit> GetVisits()
        {
            JsonManager manager = new JsonManager();

            Dictionary<string, JToken> result = manager.deserializeToDictionary(JsonType.Visits, info.PatientId);
            IList<JToken> tokens = new List<JToken>();

            foreach (KeyValuePair<string, JToken> item in result)
            {
                tokens.Add(result[item.Key]);
            }
            List<Visit> VisitList = new List<Visit>();
            foreach (var item in tokens)
            {
                VisitList.Add(item.ToObject<Visit>());
            }

            return VisitList;

        }

        public bool AddPerscription(Perscription perscription)
        {
            if (perscription == null)
            {
                return false;
            }

            try
            {
                perscriptions.Add(perscription);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddVisit(Visit visit)
        {
            if (visit == null)
            {
                return false;
            }

            try
            {
                visits.Add(visit);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Save()
        {
            if (visits == null || perscriptions == null)
            {
                return false;
            }
            else
            {
                JsonManager jsonManager = new JsonManager();
                jsonManager.AddJson(JsonType.Prescriptions, info.PatientId, perscriptions);
                jsonManager.AddJson(JsonType.Prescriptions, info.PatientId, visits);
                return true;

            }
        }
          
    }
}
