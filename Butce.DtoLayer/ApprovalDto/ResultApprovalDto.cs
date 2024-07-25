using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.DtoLayer.ApprovalDto
{
    public class ResultApprovalDto
    {

        public int ApprovalID { get; set; }

        public int ExpensesID { get; set; }

        public int LevelID { get; set; }

        public int SubLevelID { get; set; }

        public int TotalAmount { get; set; }

        public int CompanyID { get; set; }

        public int WorkDoneID { get; set; }

        public int WorkDoneTypeID { get; set; }

        public int VATID { get; set; }

        public int ExcVAT { get; set; }

        public int InVAT { get; set; }
    }
}
