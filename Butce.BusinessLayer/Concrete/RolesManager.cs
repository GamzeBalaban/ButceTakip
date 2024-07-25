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
    public class RolesManager : IRolesService
    {

        private readonly IRolesDal _rolesDal;

        public RolesManager(IRolesDal rolesDal)
        {
            _rolesDal = rolesDal;
        }

        public void TAdd(Roles entity)
        {
            _rolesDal.Add(entity);
        }

        public void TDelete(Roles entity)
        {
            _rolesDal.Delete(entity);
        }

        public List<Roles> TGetAll()
        {
            return _rolesDal.GetAll();
        }

        public Roles TGetByID(int id)
        {
            return _rolesDal.GetByID(id);
        }

        public void TUpdate(Roles entity)
        {
            _rolesDal.Update(entity);
        }
    }
}
