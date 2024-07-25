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
    public class RefuseManager : IRefuseService
    {
        private readonly IRefuseDal _refuseDal;

        public RefuseManager(IRefuseDal refuseDal)
        {
            _refuseDal = refuseDal;
        }

        public void TAdd(Refuse entity)
        {
            _refuseDal.Add(entity);
        }

        public void TDelete(Refuse entity)
        {
            _refuseDal.Delete(entity);
        }

        public List<Refuse> TGetAll()
        {
            return _refuseDal.GetAll();
        }

        public Refuse TGetByID(int id)
        {
           return  _refuseDal.GetByID(id);
        }

        public object TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Refuse entity)
        {
            _refuseDal.Update(entity);
        }
    }
}
