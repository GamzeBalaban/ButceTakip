using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Butce.BusinessLayer.Abstract;
using Butce.DtoLayer.PlanningDto;
using Butce.EntityLayer.Entities;
using System.Numerics;
using Butce.DtoLayer.AppControlDto;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanningController : ControllerBase
    {
        private readonly IPlanningService _planningService; 

        public PlanningController(IPlanningService planningService)
        {
            _planningService = planningService;

        }
        [HttpGet]
        public IActionResult PlanningList()
        {
            var values = _planningService.TGetAll();
            return Ok(values);

        }
        [HttpPost]

        public IActionResult CreatePlanning(CreatePlanningDto createPlanningDto)
        {
            Planning planning = new Planning()
            {
                PlanID = createPlanningDto.PlanID,
                CompanyID = createPlanningDto.CompanyID,
                WorkDoneID = createPlanningDto.WorkDoneID,
                WorkDoneTypeID = createPlanningDto.WorkDoneTypeID,
                VATID = createPlanningDto.VATID,
                ExcVAT = createPlanningDto.ExcVAT,
                InVAT = createPlanningDto.InVAT,
                PayStatus = createPlanningDto.PayStatus,
                UsableBudget = createPlanningDto.UsableBudget,
                AvailableBudget = createPlanningDto.AvailableBudget,
                RemaningBudget = createPlanningDto.RemaningBudget,
                TotalExpenditure = createPlanningDto.TotalExpenditure,
                RowNumber = createPlanningDto.RowNumber,
                Documents = createPlanningDto.Documents,
                PlanningImage = createPlanningDto.PlanningImage,
                ExpensesID=createPlanningDto.ExpensesID,
                LevelID=createPlanningDto.LevelID,
                BudgetAmountID  = createPlanningDto.BudgetAmountID,

            };

            _planningService.TAdd(planning);
            return Ok("Plan başarıli bir şekilde eklendi.");
        }
        [HttpDelete]
        public IActionResult DeletePlanning(int id)
        {
            var value=_planningService.TGetByID(id);
            _planningService.TDelete(value);
            return Ok("Plan silindi.");
        }
        [HttpPut]
        public IActionResult UpdatePlanning(UpdatePlanningDto updatePlanningDto)
        {
            Planning planning = new Planning()
            {
                PlanID = updatePlanningDto.PlanID,
                CompanyID = updatePlanningDto.CompanyID,
                LevelID= updatePlanningDto.LevelID,
                ExpensesID = updatePlanningDto.ExpensesID,
                WorkDoneID = updatePlanningDto.WorkDoneID,
                WorkDoneTypeID = updatePlanningDto.WorkDoneTypeID,
                VATID = updatePlanningDto.VATID,
                ExcVAT = updatePlanningDto.ExcVAT,
                InVAT = updatePlanningDto.InVAT,
                PayStatus = updatePlanningDto.PayStatus,
                UsableBudget = updatePlanningDto.UsableBudget,
                AvailableBudget = updatePlanningDto.AvailableBudget,
                RemaningBudget = updatePlanningDto.RemaningBudget,
                TotalExpenditure = updatePlanningDto.TotalExpenditure,
                RowNumber = updatePlanningDto.RowNumber,
                Documents = updatePlanningDto.Documents,
                PlanningImage = updatePlanningDto.PlanningImage

            };

            _planningService.TUpdate(planning);
            return Ok("Plan Güncellendi.");
        }
            [HttpGet("GetPlanning")]
        public IActionResult GetPlanning(int id)
        {
           var value= _planningService.TGetByID(id);
            return Ok(value);

        }
    }
}
