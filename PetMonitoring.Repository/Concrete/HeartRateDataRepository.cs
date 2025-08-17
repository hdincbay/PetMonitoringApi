using PetMonitoring.Entity.Model;
using PetMonitoring.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Repository.Concrete
{
    public class HeartRateDataRepository : RepositoryBase<HeartRateData>, IHeartRateDataRepository
    {
        public HeartRateDataRepository(RepositoryContext context) : base(context)
        {
        }
        public void CreateHeartRateData(HeartRateData heartRateData) => Create(heartRateData);

        public void DeleteHeartRateData(HeartRateData heartRateData) => Delete(heartRateData);

        public IQueryable<HeartRateData> GetAllHeartRateDatas(bool trackChanges) => FindAll(trackChanges);
        public HeartRateData? GetByHeartRateId(int id, bool trackChanges) => FindByCondition(x => x.HeartRateId.Equals(id), trackChanges);

        public void UpdateHeartRateData(HeartRateData heartRateData) => Update(heartRateData);
    }
}
