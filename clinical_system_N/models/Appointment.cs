using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal class Appointment
    {
        public Patient _patient;
        public Doctor _doctor;
        public DateTime _date;
        public int _time;
        public int min;
        public string Id;
        public ClinicType ClinicType;

        public Appointment(Patient patient, Doctor doctor, ClinicType clinic)
        {
            _patient = patient;
            _doctor = doctor;
            _date = DateTime.Now;
            _time = _date.Hour;
            min = _date.Minute;
            Id = Guid.NewGuid().ToString();
            ClinicType = clinic;
        }
    }
}
