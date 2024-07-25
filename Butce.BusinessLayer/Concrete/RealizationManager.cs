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
    public class RealizationManager : IRealizationService
    {

        private readonly IRealizationDal _realizationDal;

        public RealizationManager(IRealizationDal realizationDal)
        {
            _realizationDal = realizationDal;
        }

        public void TAdd(Realization entity)
        {
            _realizationDal.Add(entity);
        }

        public void TDelete(Realization entity)
        {
            _realizationDal.Delete(entity);
        }

        public List<Realization> TGetAll()
        {
            return _realizationDal.GetAll();
        }

        public Realization TGetByID(int id)
        {
            return _realizationDal.GetByID(id);
        }

        public void TUpdate(Realization entity)
        {
            _realizationDal.Update(entity);
        }
    }
}
