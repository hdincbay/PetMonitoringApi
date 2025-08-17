using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Repository.Contract
{
    public interface IRepositoryManager
    {
        public IDeviceRepository Device { get; }
        public IHeartRateDataRepository HeartRateData { get; }
        public IMovementDataRepository MovementData { get; }
        public ITemperatureDataRepository TemperatureData { get; }
        public void Save();
    }
}
