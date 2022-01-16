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

        public Patient(PatientInformation information)
        {
            info = information;

        }
    }
}
