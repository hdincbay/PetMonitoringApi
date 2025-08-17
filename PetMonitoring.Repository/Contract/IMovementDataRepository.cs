using PetMonitoring.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMonitoring.Repository.Contract
{
    public interface IMovementDataRepository : IRepositoryBase<MovementData>
    {
        public IQueryable<MovementData> GetAllMovementDatas(bool trackChanges);
        public MovementData? GetByMovementDataId(int id, bool trackChanges);
        public void CreateMovementData(MovementData movementData);
        public void UpdateMovementData(MovementData movementData);
        public void DeleteMovementData(MovementData movementData);
    }
}
