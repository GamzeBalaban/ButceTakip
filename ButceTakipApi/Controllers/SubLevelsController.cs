using Butce.BusinessLayer.Abstract;
using Butce.DtoLayer.SubLevelsDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubLevelsController : ControllerBase
    {
        private readonly ISubLevelsService _subLevelsService;

        public SubLevelsController(ISubLevelsService subLevelsService)
        {
            _subLevelsService = subLevelsService;
        }
        [HttpGet]
        public IActionResult SubLevelsList()
        {
            var values = _subLevelsService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateSublevels(CreateSubLevelsDto createSubLevelsDto)
        {
            SubLevels sublevels = new SubLevels()
            {
                LevelID = createSubLevelsDto.LevelID,
                SubLevelID = createSubLevelsDto.SubLevelID,
                SubLevelNo = createSubLevelsDto.SubLevelNo,

            };
            _subLevelsService.TAdd(sublevels);
            return Ok("Başarılı bir şekilde onaylandı");
        }
        [HttpDelete]
        public IActionResult DeleteSubLevels(int id)
        {
            var value = _subLevelsService.TGetByID(id);
            _subLevelsService.TDelete(value);
            return Ok("Bütçe işlemi onaylanmadı.");
        }
        [HttpPut]
        public ISubLevelsService UpdateSubLevels(UpdateSubLevelsDto updateSubLevelsDto)
        {
            SubLevels sublevels = new SubLevels()
            {
              LevelID= updateSubLevelsDto.LevelID,
              SubLevelID= updateSubLevelsDto.SubLevelID,
              SubLevelNo= updateSubLevelsDto.SubLevelNo,

            };
            _subLevelsService.TUpdate(sublevels);

            return (ISubLevelsService)Ok("Bütçe onayı güncellendi.");

        }
        [HttpGet("GetSubLevels")]

        public IActionResult GetSubLevels(int id)
        {
            var value = _subLevelsService.TGetByID(id);
            return Ok(value);

        }
    }
}
