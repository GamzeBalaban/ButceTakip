using Butce.BusinessLayer.Abstract;
using Butce.DtoLayer.WorkDoneDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class WorkDoneController : ControllerBase
    {
        private readonly IWorkDoneService _workDoneService;

        public WorkDoneController(IWorkDoneService workDoneService)
        {
            _workDoneService = workDoneService;
        }
        [HttpGet]
        public IActionResult WorkDoneList()
        {
            var values = _workDoneService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateWorkDone(CreateWorkDoneDto createWorkDoneDto)
        {
            WorkDone workDone = new WorkDone()
            {
                WorkDoneName = createWorkDoneDto.WorkDoneName,
                WorkDoneID = createWorkDoneDto.WorkDoneID,

            };

            _workDoneService.TAdd(workDone);
            return Ok("Başarılı bir şekilde onaylandı");
        }
        [HttpDelete]
        public IActionResult DeleteWorkDone(int id)
        {
            var value = _workDoneService.TGetByID(id);
            _workDoneService.TDelete(value);
            return Ok("Yapılan iş işlemi onaylanmadı.");
        }
        [HttpPut]
        public IAddUserService UpdateWorkDone(UpdateWorkDoneDto updateWorkDoneDto)
        {
            WorkDone workDone = new WorkDone()
            {
                WorkDoneName = updateWorkDoneDto.WorkDoneName,
                WorkDoneID = updateWorkDoneDto.WorkDoneID,



            };
            _workDoneService.TUpdate(workDone);

            return (IAddUserService)Ok("Bütçe onayı güncellendi.");

        }
        [HttpGet("GetWorkDone")]

        public IActionResult GetWorkDone(int id)
        {
            var value = _workDoneService.TGetByID(id);
            return Ok(value);

        }


    }
}

