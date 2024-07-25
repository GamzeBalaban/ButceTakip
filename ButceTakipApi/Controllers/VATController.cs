using Butce.BusinessLayer.Abstract;
using Butce.DtoLayer.VATDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class VATController : ControllerBase
    {
        private readonly IVATService _vatService;

        public VATController(IVATService vatService)
        {
            _vatService = vatService;
        }
        [HttpGet]
        public IActionResult VATList()
        {
            var values = _vatService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateVAT(CreateVATDto createVATDto)
        {
            VAT vat = new VAT()
            {
                VATID = createVATDto.VATID,
                VATRate = createVATDto.VATRate,
            };

            _vatService.TAdd(vat);
            return Ok("Başarılı bir şekilde onaylandı");
        }
        [HttpDelete]
        public IActionResult DeleteVAT(int id)
        {
            var value = _vatService.TGetByID(id);
            _vatService.TDelete(value);
            return Ok("Yapılan KDV işlemi onaylanmadı.");
        }
        [HttpPut]
        public IVATService UpdateVAT(UpdateVATDto updateVATDto)
        {
            VAT vat = new VAT()
            {
                 VATID = updateVATDto.VATID,
                 VATRate = updateVATDto.VATRate,

            };
            _vatService.TUpdate(vat);

            return (IVATService)Ok("Bütçe onayı güncellendi.");

        }
        [HttpGet("GetVAT")]

        public IActionResult GetVAT(int id)
        {
            var value = _vatService.TGetByID(id);
            return Ok(value);

        }


    }
}