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
    public class PlanningManager : IPlanningService
    {

        private readonly IPlanningDal _planningDal;

        public PlanningManager(IPlanningDal planningDal)
        {
            _planningDal = planningDal;
        }

        public void TAdd(Planning entity)
        {
            _planningDal.Add(entity);
        }

        public void TDelete(Planning entity)
        {
            _planningDal.Delete(entity);
        }

        public List<Planning> TGetAll()
        {
            return _planningDal.GetAll();
        }

        public Planning TGetByID(int id)
        {
            return _planningDal.GetByID(id);
        }

        public void TUpdate(Planning entity)
        {
            _planningDal.Update(entity);
        }
    }
}
