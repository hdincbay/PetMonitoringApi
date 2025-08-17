using PetMonitoring.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Repository.Contract
{
    public interface IDeviceRepository : IRepositoryBase<Device>
    {
        public IQueryable<Device> GetAllDevices(bool trackChanges);
        public Device? GetByDeviceId(int id, bool trackChanges);
        public void CreateDevice(Device device);
        public void UpdateDevice(Device device);
        public void DeleteDevice(Device device);

    }
}
