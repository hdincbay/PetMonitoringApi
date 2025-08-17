using PetMonitoring.Entity.Model;
using PetMonitoring.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Repository.Concrete
{
    public class DeviceRepository : RepositoryBase<Device>, IDeviceRepository
    {
        public DeviceRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateDevice(Device device) => Create(device);
        public void DeleteDevice(Device device) => Delete(device);
        public IQueryable<Device> GetAllDevices(bool trackChanges) => FindAll(trackChanges);
        public Device? GetByDeviceId(int id, bool trackChanges) => FindByCondition(x => x.DeviceId.Equals(id), trackChanges);
        public void UpdateDevice(Device device) => Update(device);
    }
}
