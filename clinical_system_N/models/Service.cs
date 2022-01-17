using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal class Service
    {
        public string Service_Code { get; set; }
        public string Service_Description { get; set; }
        public int Quantity { get; set; }
        public int Unit { get; set; }
        public float Price { get; set; }
        public string Duration { get; set; }
    }
}
