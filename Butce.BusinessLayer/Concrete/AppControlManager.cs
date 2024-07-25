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
    public class AppControlManager : IAppControlService
    {
        private readonly IAppControlDal _appcontrolDal;

        public AppControlManager(IAppControlDal appcontrolDal)
        {
            _appcontrolDal = appcontrolDal;
        }

        public void TAdd(AppControl entity)
        {
            _appcontrolDal.Add(entity);
        }

        public void TDelete(AppControl entity)
        {
            _appcontrolDal.Delete(entity);
        }

        public List<AppControl> TGetAll()
        {
            return _appcontrolDal.GetAll();
        }

        public AppControl TGetByID(int id)
        {
           return  _appcontrolDal.GetByID(id);
        }

        public AppControl TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public object TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppControl entity)
        {
            _appcontrolDal.Update(entity);
        }
    }
}
