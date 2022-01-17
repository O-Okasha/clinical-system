using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal class Device
    {
        public string DeviceName { get; set; }
        public string CompanyName { get; set; }
        public string Details { get; set; }

        Device(string deviceName, string companyName, string details)
        {
            DeviceName = deviceName;
            CompanyName = companyName;
            Details = details;
        }
    }
}
