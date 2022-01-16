using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal class PatientInformation
    {
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string DoB { get; set; }
        public string NationalID { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public MaritialStatus MaritialStatus { get; set; }
        public string Proffession { get; set; }

        public PatientInformation(string patientID, string patientname, string dob, string nationalID, Gender gender, string email, string phone, string address, MaritialStatus maritialStatus, string proffession)
        {
            PatientId = patientID;
            PatientName = patientname;
            DoB = dob;
            NationalID = nationalID;
            Gender = gender;
            Email = email;
            Phone = phone;
            Address = address;
            MaritialStatus = maritialStatus;
            Proffession = proffession;
        }
    }
}
