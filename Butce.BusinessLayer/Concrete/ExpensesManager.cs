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
    public class ExpensesManager : IExpensesService
    {
        private readonly IExpensesDal _expensesDal;

        public ExpensesManager(IExpensesDal expensesDal)
        {
            _expensesDal = expensesDal;
        }

        public void TAdd(Expenses entity)
        {
            _expensesDal.Add(entity);
        }

        public void TDelete(Expenses entity)
        {
            _expensesDal.Delete(entity);
        }

        public List<Expenses> TGetAll()
        {
            return _expensesDal.GetAll();
        }

        public Expenses TGetByID(int id)
        {
            return _expensesDal.GetByID(id);
        }

        public void TUpdate(Expenses entity)
        {
            _expensesDal.Update(entity);
        }
    }
}
