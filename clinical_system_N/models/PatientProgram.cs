using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal class PatientProgram
    {
        public string Id { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public string SDate { get; set; }

        public PatientProgram (string id, Patient patient, Doctor doctor, string sDate)
        {
            Id = id;
            Patient = patient;  
            Doctor = doctor;
            SDate = sDate;
        }
    }
}
