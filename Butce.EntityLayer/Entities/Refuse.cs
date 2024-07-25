using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class Refuse
    {
        [Key]
        public int RefuseID { get; set; }

        [Required]
        [StringLength(50)]
        public string RefuseReason { get; set; }

        [Required]
        public int ExpensesID { get; set; }

        [ForeignKey("ExpensesID")]
        public virtual Expenses Expenses { get; set; }
    
    }

}
