using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class BudgetAmount
    {
        [Key]
        public int BudgetAmountID { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}
