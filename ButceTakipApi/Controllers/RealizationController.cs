using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Butce.BusinessLayer.Abstract;
using Butce.DtoLayer.RealizationDto;
using Butce.EntityLayer.Entities;
using System.Reflection.Emit;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealizationController : ControllerBase
    {
        private readonly IRealizationService _realizationService;
        public RealizationController(IRealizationService realizationService) {
        _realizationService = realizationService;

        }
        [HttpGet]
        public IActionResult RealizationList()
        {
            var values = _realizationService.TGetAll();
            return Ok(values);


        }
        [HttpDelete]

        public IActionResult DeleteRealization(int id) 
        {
            var value = _realizationService.TGetByID(id); ;
            _realizationService.TDelete(value);
            return Ok("Gerçekleştirme planı silindi.");

        }
        [HttpPut]
        public IActionResult UpdateRealization (UpdateRealizationDto updateRealizationDto)
        {

            Realization realization = new Realization()
            {
                RealizationID = updateRealizationDto.RealizationID,
                WorkDoneID = updateRealizationDto.WorkDoneID,
                PayStatus=updateRealizationDto.PayStatus,
                UsableBudget = updateRealizationDto.UsableBudget,
                RemainingBudget = updateRealizationDto.RemaningBudget,
                TotalExpenditure = updateRealizationDto.TotalExpenditure,
                TotalAmount = updateRealizationDto.TotalAmount,
                BudgetTypeID = updateRealizationDto.BudgetTypeID,
                CompanyID = updateRealizationDto.CompanyID,
                ExcVAT=updateRealizationDto.ExcVAT,
                ID = updateRealizationDto.ID,
                InVAT = updateRealizationDto.InVAT,
                LevelID = updateRealizationDto.LevelID,
                SubLevelID = updateRealizationDto.SubLevelID,
                VATID = updateRealizationDto.VATID,
                WorkDoneTypeID= updateRealizationDto.WorkDoneTypeID,

            };

    _realizationService.TUpdate(realization);
            return Ok("Gerçekleştirme planı silindi.");

        }
        [HttpGet("GetRealizatiın")]
        public IActionResult GetRealization(int id)
        {
           var value= _realizationService.TGetByID(id);
            return Ok(value);
        }
    }
}
