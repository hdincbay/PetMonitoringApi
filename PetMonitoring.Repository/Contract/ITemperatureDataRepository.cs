using PetMonitoring.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Repository.Contract
{
    public interface ITemperatureDataRepository : IRepositoryBase<TemperatureData>
    {
        public IQueryable<TemperatureData> GetAllTemperatureDatas(bool trackChanges);
        public TemperatureData? GetByTemperatureDataId(int id, bool trackChanges);
        public void CreateTemperatureData(TemperatureData temperatureData);
        public void UpdateTemperatureData(TemperatureData temperatureData);
        public void DeleteTemperatureData(TemperatureData temperatureData);
    }
}
