using PetMonitoring.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Entity.Model
{
    public class Device
    {
        public Device()
        {
            CreatedDate = DateTime.Now;
        }
        public int DeviceId { get; set; }
        public string? SerialNumber { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public string? PetName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedById { get; set; }
        public User? CreatedBy { get; set; }
    }
}
