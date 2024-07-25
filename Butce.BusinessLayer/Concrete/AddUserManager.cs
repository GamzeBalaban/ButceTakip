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
    public class AddUserManager : IAddUserService
    {
        private readonly IAddUserDal _addUserDal;

        public AddUserManager(IAddUserDal addUserDal)
        {
            _addUserDal = addUserDal;
        }

        public void TAdd(AddUser entity)
        {
            _addUserDal.Add(entity);
        }

        public void TDelete(AddUser entity)
        {
            _addUserDal.Delete(entity);
        }

        public List<AddUser> TGetAll()
        {
            return _addUserDal.GetAll();
        }

        public AddUser TGetByID(int id)
        {
            return _addUserDal.GetByID(id);
        }

        public void TUpdate(AddUser entity)
        {
            _addUserDal.Update(entity);
        }
    }
}
