using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Entity.Model
{
    public class HeartRateData
    {
        public HeartRateData()
        {
            RecordedDate = DateTime.Now;
        }
        public int HeartRateId { get; set; }
        public int DeviceId { get; set; }
        public Device? Device { get; set; }
        public float BPM { get; set; }
        public DateTime? RecordedDate { get; set; }
    }
}
