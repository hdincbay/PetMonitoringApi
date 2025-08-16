using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Entity.Model
{
    public class MovementData
    {
        public int MovementId { get; set; }
        public int DeviceId { get; set; }
        public Device? Device { get; set; }

    }
}
