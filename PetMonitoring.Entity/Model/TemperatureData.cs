using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Entity.Model
{
    public class TemperatureData
    {
        public TemperatureData()
        {
            RecordedDate = DateTime.Now;
        }
        public int TemperatureDataId { get; set; }
        public int DeviceId { get; set; }
        public Device? Device { get; set; }
        public float CValue { get; set; }
        public float FValue { get; set; }
        public DateTime RecordedDate { get; set; }
    }
}
