namespace ButceTakipWebUI.Dtos.BudgetDtos
{
    public class CreateBudgetDto
    {
        public int BudgetTypeID { get; set; }
        public string BudgetType { get; set; }
        public bool Status { get; internal set; }
    }
}
