using Butce.BusinessLayer.Abstract;
using Butce.DataAccessLayer.Abstract;
using Butce.DtoLayer.AppControlDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppControlController : ControllerBase
    {
        private readonly IAppControlService _appControlService;
        public AppControlController (IAppControlService appControlService)
        {
            _appControlService = appControlService;
        }
        [HttpGet]
        public IActionResult AppControlList()
        {
            var values = _appControlService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAppControl(CreateAppControlDto createAppControlDto)
        {
            AppControl appControl = new AppControl()
            {
                ID = createAppControlDto.ID,
                AppControls = createAppControlDto.AppControls,
                ExpensesID= createAppControlDto.ExpensesID,
            };
                _appControlService.TAdd(appControl);
            return Ok("Bütçe talebi başarılı bir şekilde eklendi.");

        
        }
        [HttpDelete]
        public IActionResult DeleteAppControl(int id)
        {
            var value=_appControlService.TGetById(id);
            _appControlService.TDelete(value);
            return Ok("Bütçe talebi silindi.");

        }
  
        [HttpGet("GetAppControl")]
        public IActionResult GetAppControl(int id) 
        {
         var value=  _appControlService.TGetByID(id);
            return Ok(value);

        }


    }

}
