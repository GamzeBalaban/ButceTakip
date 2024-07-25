using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.DtoLayer.ExpensesDto
{
    public class CreateExpensesDto
    {
        public int ExpensesID { get; set; }
        public string ExpensesType { get; set; }

        public int BudgetTypeID { get; set; }
    }
}
