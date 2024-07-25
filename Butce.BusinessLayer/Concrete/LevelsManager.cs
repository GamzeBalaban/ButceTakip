using Butce.BusinessLayer.Abstract;
using Butce.DataAccessLayer.Abstract;
using Butce.DataAccessLayer.EntityFramework;
using Butce.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.BusinessLayer.Concrete
{
    public class LevelsManager : ILevelsService
    {
        private readonly ILevelsDal _levelsDal;

        public LevelsManager(ILevelsDal levelsDal)
        {
            _levelsDal = levelsDal;
        }

        public void TAdd(Levels entity)
        {
            _levelsDal.Add(entity);
        }

        public void TDelete(Levels entity)
        {
            _levelsDal.Delete(entity);
        }

        public List<Levels> TGetAll()
        {
            return _levelsDal.GetAll();
        }

        public Levels TGetByID(int id)
        {
           return _levelsDal.GetByID(id);
        }

        public void TUpdate(Levels entity)
        {
            _levelsDal.Update(entity);
        }
    }
}
