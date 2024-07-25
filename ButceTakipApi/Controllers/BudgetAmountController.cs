using Butce.BusinessLayer.Abstract;
using Butce.DtoLayer.BudgetAmountDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetAmountController : ControllerBase
    {

        private readonly IBudgetAmountService _budgetAmountService;
        public BudgetAmountController(IBudgetAmountService budgetAmountService)
        {
            _budgetAmountService = budgetAmountService;
        }
        [HttpGet]
        public IActionResult BudgetAmountList()
        {
            var values = _budgetAmountService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBudgetAmount(CreateBudgetAmountDto createBudgetAmountDto)
        {
            BudgetAmount budgetAmount = new BudgetAmount()
            {
                BudgetAmountID = createBudgetAmountDto.BudgetAmountID,
                Amount = createBudgetAmountDto.Amount,
              
            };
            _budgetAmountService.TAdd(budgetAmount);
            return Ok("Bütçe talebi başarılı bir şekilde eklendi.");


        }
        [HttpDelete]
        public IActionResult DeleteBudgetAmount(int id)
        {
            var value = _budgetAmountService.TGetByID(id);
            _budgetAmountService.TDelete(value);
            return Ok("Bütçe talebi silindi.");

        }

        [HttpGet("GetBudgetAmount")]
        public IActionResult GetBudgetAmount(int id)
        {
            var value = _budgetAmountService.TGetByID(id);
            return Ok(value);

        }
    }
}
