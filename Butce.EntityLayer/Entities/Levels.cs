using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class Levels
    {
        [Key]
        public int LevelID { get; set; }

        public int? ExpensesID { get; set; }

        [Required]
        public int LevelNo { get; set; }

        [ForeignKey("ExpensesID")]
        public virtual Expenses Expenses { get; set; }

 
    }

}
