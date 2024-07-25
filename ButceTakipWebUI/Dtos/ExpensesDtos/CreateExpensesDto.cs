
namespace ButceTakipWebUI.Dtos.ExpensesDtos
{
    public class CreateExpensesDto
    {
        public int ExpensesID { get; set; }
        public string ExpensesType { get; set; }

        public int BudgetTypeID { get; set; }
    }
}
