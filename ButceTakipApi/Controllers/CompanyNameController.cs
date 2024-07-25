using Butce.BusinessLayer.Abstract;

using Butce.DtoLayer.CompanyNameDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyNameController : ControllerBase
    {


        private readonly ICompanyNameService _companynameService;

        public CompanyNameController(ICompanyNameService companynameService)
        {
            _companynameService = companynameService;
        }
        [HttpGet]
        public IActionResult CompanyNameList()
        {
            var values = _companynameService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public   IActionResult CreateCompanyName(CreateCompanyNameDto createCompanyNameDto)
        {
            CompanyName companyname = new CompanyName()
            {
                CompanyNames=createCompanyNameDto.CompanyNames,
                CompanyID=createCompanyNameDto.CompanyID,

            };

            _companynameService.TAdd(companyname);
            return Ok("Başarılı bir şekilde onaylandı");
        }
        [HttpDelete]
        public IActionResult DeleteCompanyName(int id)
        {
            var value = _companynameService.TGetByID(id);
            _companynameService.TDelete(value);
            return Ok("Bütçe işlemi onaylanmadı.");
        }
        [HttpPut]
        public ICompanyNameService UpdateCompanyName(UpdateCompanyNameDto updateCompanyNameDto)
        {
            CompanyName companyname = new CompanyName()
            {
                CompanyNames = updateCompanyNameDto.CompanyNames,
                CompanyID = updateCompanyNameDto.CompanyID,

            };
            _companynameService.TUpdate(companyname);

            return (ICompanyNameService)Ok("Bütçe onayı güncellendi.");

        }
        [HttpGet("GetCompanyName")]

        public IActionResult GetAddUser(int id)
        {
            var value = _companynameService.TGetByID(id);
            return Ok(value);

        }


    }
}

