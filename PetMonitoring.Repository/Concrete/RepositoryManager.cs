using PetMonitoring.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Repository.Concrete
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly IDeviceRepository _deviceRepository;
        private readonly IHeartRateDataRepository _heartRateDataRepository;
        private readonly IMovementDataRepository _movementDataRepository;
        private readonly ITemperatureDataRepository _temperatureDataRepository;
        private readonly RepositoryContext _context;

        public RepositoryManager(IDeviceRepository deviceRepository, IHeartRateDataRepository heartRateDataRepository, IMovementDataRepository movementDataRepository, ITemperatureDataRepository temperatureDataRepository, RepositoryContext context)
        {
            _deviceRepository = deviceRepository;
            _heartRateDataRepository = heartRateDataRepository;
            _movementDataRepository = movementDataRepository;
            _temperatureDataRepository = temperatureDataRepository;
            _context = context;
        }

        public IDeviceRepository Device => _deviceRepository;

        public IHeartRateDataRepository HeartRateData => _heartRateDataRepository;

        public IMovementDataRepository MovementData => _movementDataRepository;

        public ITemperatureDataRepository TemperatureData => _temperatureDataRepository;

        public void Save() => _context.SaveChanges();
    }
}
