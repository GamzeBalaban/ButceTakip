using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Butce.DataAccessLayer.Abstract;
using Butce.DataAccessLayer.Concrete;
using Butce.DataAccessLayer.Repositories;
using Butce.EntityLayer.Entities;

namespace Butce.DataAccessLayer.EntityFramework
{
    public class EfBudgetAmountDal : GenericRepository<BudgetAmount>, IBudgetAmountDal

    {
        public EfBudgetAmountDal(BudgetContext context) : base(context)
        {
        }
    }
}
