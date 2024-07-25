using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class Realization
    {
        [Key]
        public int RealizationID { get; set; }

        [Required]
        public int WorkDoneID { get; set; }

        [Required]
        public int TotalAmount { get; set; }

        [Required]
        public bool PayStatus { get; set; }

        [Required]
        public float UsableBudget { get; set; }

        [Required]
        public float RemainingBudget { get; set; }

        [Required]
        public float TotalExpenditure { get; set; }

        [Required]
        public int BudgetTypeID { get; set; }

        [Required]
        public int ID { get; set; }

        [Required]
        public int LevelID { get; set; }

        [Required]
        public int SubLevelID { get; set; }

        [Required]
        public int VATID { get; set; }

        [Required]
        public int ExcVAT { get; set; }

        [Required]
        public int InVAT { get; set; }

        [Required]
        public int CompanyID { get; set; }

        [Required]
        public int WorkDoneTypeID { get; set; }

        [ForeignKey("ID")]
        public virtual AppControl AppControl { get; set; }

        [ForeignKey("LevelID")]
        public virtual Levels Levels { get; set; }

        [ForeignKey("SubLevelID")]
        public virtual SubLevels SubLevels { get; set; }

        [ForeignKey("CompanyID")]
        public virtual CompanyName CompanyName { get; set; }

        [ForeignKey("VATID")]
        public virtual VAT VAT { get; set; }

        [ForeignKey("WorkDoneID")]
        public virtual WorkDone WorkDone { get; set; }

        [ForeignKey("WorkDoneTypeID")]
        public virtual WorkDoneType WorkDoneType { get; set; }

        [ForeignKey("BudgetTypeID")]
        public virtual Budget Budget { get; set; }
       
    }

}
