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
    public class LoginManager : ILoginService
    {
        private readonly ILoginDal _loginDal;

        public LoginManager(ILoginDal loginDal)
        {
            _loginDal = loginDal;
        }

        public void TAdd(Login entity)
        {
            _loginDal.Add(entity);
        }

        public void TDelete(Login entity)
        {
            _loginDal.Delete(entity);
        }

        public List<Login> TGetAll()
        {
            return _loginDal.GetAll();
        }

        public Login TGetByID(int id)
        {
            return _loginDal.GetByID(id);
        }

        public void TUpdate(Login entity)
        {
            _loginDal.Update(entity);
        }
    }
}
