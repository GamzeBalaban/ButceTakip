using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.DtoLayer.RefuseDto
{
    public class GetRefuseDto
    {
        public int RefuseID { get; set; }

        public string RefuseReason { get; set; }

        public int ExpensesID { get; set; }

    }
}
