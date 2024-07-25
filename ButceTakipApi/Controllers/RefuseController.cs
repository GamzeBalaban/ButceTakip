using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Butce.BusinessLayer.Abstract;
using Butce.DtoLayer.RefuseDto;
using Butce.EntityLayer.Entities;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RefuseController : ControllerBase
    {
        private readonly IRefuseService _refuseService;
        public RefuseController(IRefuseService refuseService)
        {
            _refuseService = refuseService;
        }
        [HttpGet]
        public IActionResult ResultList()
        {
            var values = _refuseService.TGetAll();
            return Ok(values);
        }
        [HttpDelete]
        public IActionResult DeleteRefuse(int id) 
        {
            var value =_refuseService.TGetByID(id);
            _refuseService.TDelete(value);
            return Ok("Reddetme silindi");
        }
        [HttpGet("GetRefuse")]
        public IActionResult GetRefuse(int id)
        {
            var value=_refuseService.TGetByID(id);
            return Ok(value);
        }

    }
}
