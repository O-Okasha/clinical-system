using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal class Visit
    {
        public string Id { get;}
        public string Date { get;}
        public string PatientName { get;}
        public string PatientID { get;}
        public string DoctorName { get;}
        public string DoctorID { get;}
        public string VisitedClinic { get;}  

        public Visit(Patient patient, Doctor doctor, ClinicType clinic)
        {
            Id = Guid.NewGuid().ToString();
            Date = DateTime.Now.ToString();
            PatientName = patient.info.PatientName;
            PatientID = patient.info.PatientId;
            DoctorName = doctor.Name;
            DoctorID = doctor.Id;
            VisitedClinic = GlobalVariables.ClinicToText(clinic);

        }
    }
}
