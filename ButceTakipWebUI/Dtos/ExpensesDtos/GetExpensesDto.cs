namespace ButceTakipWebUI.Dtos.ExpensesDtos
{
    public class GetExpensesDto
    {
        public int ExpensesID { get; set; }
        public string ExpensesType { get; set; }

        public int BudgetTypeID { get; set; }
    }
}
