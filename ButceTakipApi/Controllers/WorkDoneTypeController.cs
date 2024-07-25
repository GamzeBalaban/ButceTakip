using Butce.BusinessLayer.Abstract;
using Butce.DtoLayer.AddUser;
using Butce.DtoLayer.AddUserDto;
using Butce.DtoLayer.WorkDoneTypeDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkDoneTypeController : ControllerBase
    {

        private readonly IWorkDoneTypeService _workDoneTypeService;

        public WorkDoneTypeController(IWorkDoneTypeService workDoneTypeService)
        {
            _workDoneTypeService = workDoneTypeService;
        }

        [HttpGet]
        public IActionResult WorkDoneTypeList()
        {
            var values = _workDoneTypeService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateWorkDoneType(CreateWorkDoneTypeDto createWorkDoneTypeDto)
        {
            WorkDoneType workdone = new WorkDoneType()
            {
                WorkDoneTypeName = createWorkDoneTypeDto.WorkDoneTypeName,
                WorkDoneTypeID = createWorkDoneTypeDto.WorkDoneTypeID,
            };

            _workDoneTypeService.TAdd(workdone);
            return Ok("Başarılı bir şekilde onaylandı");
        }
        [HttpDelete]
        public IActionResult DeleteWorkDoneType(int id)
        {
            var value = _workDoneTypeService.TGetByID(id);
            _workDoneTypeService.TDelete(value);
            return Ok("Bütçe işlemi onaylanmadı.");
        }
        [HttpPut]
        public IWorkDoneTypeService UpdateWorkDoneType(UpdateWorkDoneTypeDto updateWorkDoneTypeDto)
        {
            WorkDoneType workdone = new WorkDoneType()
            {
                WorkDoneTypeName = updateWorkDoneTypeDto.WorkDoneTypeName,
                WorkDoneTypeID= updateWorkDoneTypeDto.WorkDoneTypeID,
            };
            _workDoneTypeService.TUpdate(workdone);

            return (IWorkDoneTypeService)Ok("Bütçe onayı güncellendi.");

        }
        [HttpGet("GetWorkDoneType")]

        public IActionResult GetWorkDoneType(int id)
        {
            var value = _workDoneTypeService.TGetByID(id);
            return Ok(value);

        }
    }
}
