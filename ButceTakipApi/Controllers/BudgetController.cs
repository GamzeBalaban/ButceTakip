using Butce.BusinessLayer.Abstract;
using Butce.DataAccessLayer.Abstract;
using Butce.DtoLayer.BudgetDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
	public class BudgetController : ControllerBase
	{
		private readonly IBudgetService _budgetService;
		public BudgetController(IBudgetService budgetService)
		{
			_budgetService = budgetService;
		}
		[HttpGet]
		public IActionResult BudgetList()
		{
			var values = _budgetService.TGetAll();
			return Ok(values);

		}
		[HttpPost]
		public IActionResult CreateBudget(CreateBudgetDto createBudgetDto)
		{
			Budget budget = new Budget()
			{
				BudgetTypeID = createBudgetDto.BudgetTypeID,
				BudgetType = createBudgetDto.BudgetType
			};
			_budgetService.TAdd(budget);
			return Ok("Bütçe Tipi başarıyla eklendi.");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteBudget(int id)
		{
			var value = _budgetService.TGetByID(id);
			_budgetService.TDelete(value);
			return Ok("Bütçe Tipi Silindi.");

		}
		[HttpPut]
		public IActionResult UpdateBudget(UpdateBudgetDto updateBudgetDto)
		{
			Budget budget = new Budget()
			{
				BudgetTypeID = updateBudgetDto.BudgetTypeID,
				BudgetType = updateBudgetDto.BudgetType
			};
			_budgetService.TUpdate(budget);
			return Ok("Bütçe Tipi Güncellendi.");


		}
        [HttpGet("{id}")]
        public IActionResult GetBudget(int id)
		{
			var value = _budgetService.TGetByID(id);
			return Ok(value);

		}
	}
}
