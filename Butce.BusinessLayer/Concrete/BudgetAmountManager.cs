using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Butce.BusinessLayer.Abstract;
using Butce.EntityLayer.Entities;
using Butce.DataAccessLayer.Abstract;
using Butce.DataAccessLayer.EntityFramework;

namespace Butce.BusinessLayer.Concrete
{
     public class BudgetAmountManager : IBudgetAmountService
    {


        private readonly IBudgetAmountDal _budgetAmountDal;

        public BudgetAmountManager(IBudgetAmountDal budgetAmountDal)
        {
            _budgetAmountDal = budgetAmountDal;
        }

        public void TAdd(BudgetAmount entity)
        {
            _budgetAmountDal.Add(entity);
        }

        public void TDelete(BudgetAmount entity)
        {
            _budgetAmountDal.Delete(entity);
        }

        public List<BudgetAmount> TGetAll()
        {
            return _budgetAmountDal.GetAll();
        }

        public BudgetAmount TGetByID(int id)
        {
            return _budgetAmountDal.GetByID(id);
        }

        public void TUpdate(BudgetAmount entity)
        {
            _budgetAmountDal.Update(entity);
        }
    }
}
