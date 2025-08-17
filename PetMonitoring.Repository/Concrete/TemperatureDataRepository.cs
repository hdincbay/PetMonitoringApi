using PetMonitoring.Entity.Model;
using PetMonitoring.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Repository.Concrete
{
    public class TemperatureDataRepository : RepositoryBase<TemperatureData>, ITemperatureDataRepository
    {
        public TemperatureDataRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateTemperatureData(TemperatureData temperatureData) => Create(temperatureData);

        public void DeleteTemperatureData(TemperatureData temperatureData) => Delete(temperatureData);

        public IQueryable<TemperatureData> GetAllTemperatureDatas(bool trackChanges) => FindAll(trackChanges);

        public TemperatureData? GetByTemperatureDataId(int id, bool trackChanges) => FindByCondition(x => x.TemperatureDataId.Equals(id), trackChanges);

        public void UpdateTemperatureData(TemperatureData temperatureData) => Update(temperatureData);
    }
}
