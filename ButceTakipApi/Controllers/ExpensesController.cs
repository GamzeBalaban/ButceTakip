using Butce.BusinessLayer.Abstract;
using Butce.DtoLayer.ExpensesDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpensesService _expensesService;

        public ExpensesController(IExpensesService expensesService)
        {
            _expensesService = expensesService;
        }
        [HttpGet]
        public IActionResult ExpensesList()
        {
            var values = _expensesService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateExpenses(CreateExpensesDto createExpensesDto)
        {
            Expenses expenses = new Expenses()
            {
                BudgetTypeID=createExpensesDto.BudgetTypeID,
                ExpensesType=createExpensesDto.ExpensesType,
                ExpensesID = createExpensesDto.ExpensesID
            };
            _expensesService.TAdd(expenses);
            return Ok("Gider Tertibi Yapıldı ");
        }
        [HttpDelete]
        public IActionResult DeleteExpenses(int id)
        {
            var value = _expensesService.TGetByID(id);
            _expensesService.TDelete(value);
            return Ok("Gider Tertibi Silindi");
        }
        [HttpPut]
        public IActionResult UpdateExpenses(UpdateExpensesDto updateExpensesDto)
        {
            Expenses expenses = new Expenses()
            {
                BudgetTypeID = updateExpensesDto.BudgetTypeID,
                ExpensesType = updateExpensesDto.ExpensesType,
                ExpensesID = updateExpensesDto.ExpensesID
            };
            _expensesService.TUpdate(expenses);
            return Ok("Gider Tertibi Güncellendi");

        }
        [HttpGet("GetExpenses")]
        public IActionResult GetExpenses(int id)
        {
            var value = _expensesService.TGetByID(id);
            return Ok(value);
        }

    }
}
