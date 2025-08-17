using PetMonitoring.Entity.Model;
using PetMonitoring.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Repository.Concrete
{
    public class MovementDataRepository : RepositoryBase<MovementData>, IMovementDataRepository
    {
        public MovementDataRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateMovementData(MovementData movementData) => Create(movementData);

        public void DeleteMovementData(MovementData movementData) => Delete(movementData);

        public IQueryable<MovementData> GetAllMovementDatas(bool trackChanges) => FindAll(trackChanges);

        public MovementData? GetByMovementDataId(int id, bool trackChanges) => FindByCondition(x => x.MovementId.Equals(id), trackChanges);

        public void UpdateMovementData(MovementData movementData) => Update(movementData);
    }
}
