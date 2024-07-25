using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.DtoLayer.BudgetDto
{
   public class CreateBudgetDto
    {
        public int BudgetTypeID { get; set; }

        public string BudgetType { get; set; }
    }
}
