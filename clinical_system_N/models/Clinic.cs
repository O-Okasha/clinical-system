using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace clinical_system_N.models
{
    internal class Clinic
    {
        public Doctor attending { get; set; }
        public List<Appointment> appointmentList { get; set; }
        public ClinicType type { get; set; }

        public Clinic(Doctor doctor, ClinicType clinicType) 
        {
            attending = doctor;
            type = clinicType;
            appointmentList = new List<Appointment>();
        }

        public void CreateAppointment(Patient patient)
        {
            Appointment appointment = new Appointment(patient, attending, type);
            appointmentList.Add(appointment);
        }

        public string Serialize()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
    }
}
