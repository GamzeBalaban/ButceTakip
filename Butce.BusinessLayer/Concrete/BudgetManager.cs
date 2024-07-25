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
    public class BudgetManager : IBudgetService
    {

        private readonly IBudgetDal _budgetDal;

        public BudgetManager(IBudgetDal budgetDal)
        {
            _budgetDal = budgetDal;
        }

        public void TAdd(Budget entity)
        {
            _budgetDal.Add(entity);
        }

        public void TDelete(Budget entity)
        {
            _budgetDal.Delete(entity);
        }

        public List<Budget> TGetAll()
        {
            return _budgetDal.GetAll();
        }

        public Budget TGetByID(int id)
        {
            return _budgetDal.GetByID(id);
        }

        public void TUpdate(Budget entity)
        {
            _budgetDal.Update(entity);
        }
    }
}
