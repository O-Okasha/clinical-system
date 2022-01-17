using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinical_system_N.models
{
    internal class PerscribedService
    {
        public string ID { get;}
        public string Date { get; }
        public Service service { get; }
        public string Quantity { get; set; }
        public string Duration { get; set; }
        public string DurationUnit { get; set; }
        public PerscribedService(Service service, int quantity, string duration, string durationUnit)
        {
            this.service = service;
            ID = Guid.NewGuid().ToString();
            Date = DateTime.Now.ToString();
            Quantity = quantity.ToString();
            Duration = duration;
            DurationUnit = durationUnit;

        }
        public void increaseQuantity()
        {
            int q = Int32.Parse(Quantity);
            q++;
            Quantity = q.ToString();
        }
        public void decreaseQuantity()
        {
            int q = Int32.Parse(Quantity);
            q--;
            Quantity = q.ToString();
        }

    }
}
