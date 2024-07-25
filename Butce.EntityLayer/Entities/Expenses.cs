using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class Expenses
    {
        [Key]
        public int ExpensesID { get; set; }

        [Required]
        public int BudgetTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string ExpensesType { get; set; }

        [ForeignKey("BudgetTypeID")]
        public virtual Budget Budget { get; set; }

       
    }
}
