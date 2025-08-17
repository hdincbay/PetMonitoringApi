using PetMonitoring.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Repository.Contract
{
    public interface IHeartRateDataRepository : IRepositoryBase<HeartRateData>
    {
        public IQueryable<HeartRateData> GetAllHeartRateDatas(bool trackChanges);
        public HeartRateData? GetByHeartRateId(int id, bool trackChanges);
        public void CreateHeartRateData(HeartRateData heartRateData);
        public void UpdateHeartRateData(HeartRateData heartRateData);
        public void DeleteHeartRateData(HeartRateData heartRateData);

    }
}
