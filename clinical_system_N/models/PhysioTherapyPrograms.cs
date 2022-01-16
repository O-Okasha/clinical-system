using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal class PhysioTherapyPrograms
    {
        public string ProgramName { get; set; }
        List<string> Details { get; set; }

        public PhysioTherapyPrograms(string programName, List <string> details)
        {
            ProgramName = programName;
            Details = details;
        }
    }
}
