using Butce.BusinessLayer.Abstract;
using Butce.DataAccessLayer.Abstract;
using Butce.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.BusinessLayer.Concrete
{
    public class SubLevelsManager : ISubLevelsService

    {
        private readonly ISubLevelsDal _subLevelsDal;

        public SubLevelsManager(ISubLevelsDal subLevelsDal)
        {
            _subLevelsDal = subLevelsDal;
        }

        public void TAdd(SubLevels entity)
        {
            _subLevelsDal.Add(entity);
        }

        public void TDelete(SubLevels entity)
        {
            _subLevelsDal.Delete(entity);
        }

        public List<SubLevels> TGetAll()
        {
            return _subLevelsDal.GetAll();
        }

        public SubLevels TGetByID(int id)
        {
            return _subLevelsDal.GetByID(id);
        }

        public void TUpdate(SubLevels entity)
        {
           _subLevelsDal.Update(entity);
        }
    }
}
