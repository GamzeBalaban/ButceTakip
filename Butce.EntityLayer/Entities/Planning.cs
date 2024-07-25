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
    public class Planning
    {
        [Key]
        public int PlanID { get; set; }

        [Required]
        public int ExpensesID { get; set; }

        [Required]
        public int BudgetAmountID { get; set; }

        [Required]
        public int CompanyID { get; set; }

        [Required]
        public int WorkDoneID { get; set; }

        [Required]
        public int WorkDoneTypeID { get; set; }

        [Required]
        public int VATID { get; set; }

        [Required]
        public int ExcVAT { get; set; }

        [Required]
        public int InVAT { get; set; }

        [Required]
        public bool PayStatus { get; set; }

        [Required]
        public float UsableBudget { get; set; }

        [Required]
        public float AvailableBudget { get; set; }

        [Required]
        public float RemaningBudget { get; set; }

        [Required]
        public float TotalExpenditure { get; set; }

        [Required]
        public int RowNumber { get; set; }

        [Required]
        public string PlanningImage { get; set; }

        [Required]
        [StringLength(50)]
        public string Documents { get; set; }

        [Required]
        public int LevelID { get; set; }

        [ForeignKey("ExpensesID")]
        public virtual Expenses Expenses { get; set; }

        [ForeignKey("CompanyID")]
        public virtual CompanyName CompanyName { get; set; }

        [ForeignKey("WorkDoneID")]
        public virtual WorkDone WorkDone { get; set; }

        [ForeignKey("WorkDoneTypeID")]
        public virtual WorkDoneType WorkDoneType { get; set; }

        [ForeignKey("VATID")]
        public virtual VAT VAT { get; set; }

        [ForeignKey("LevelID")]
        public virtual Levels Level { get; set; }

        [ForeignKey("BudgetAmountID")]
        public virtual BudgetAmount BudgetAmount { get; set; }
    }
}

