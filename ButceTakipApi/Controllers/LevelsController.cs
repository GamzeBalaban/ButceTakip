using Butce.BusinessLayer.Abstract;
using Butce.DtoLayer.AddUser;
using Butce.DtoLayer.AddUserDto;
using Butce.DtoLayer.LevelsDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelsController : ControllerBase
    {
        private readonly ILevelsService _levelsService;

        public LevelsController(ILevelsService levelsService)
        {
            _levelsService = levelsService;
        }

        [HttpGet]
        public IActionResult LevelsList()
        {
            var values = _levelsService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateLevels(CreateLevelsDto createLevelsDto)
        {
            Levels levels = new Levels()
            {
                 LevelID=createLevelsDto.LevelID,
                 ExpensesID= createLevelsDto.ExpensesID,
                 LevelNo=createLevelsDto.LevelNo,

            };
            
            _levelsService.TAdd(levels);
            return Ok("Başarılı bir şekilde onaylandı");
        }
        [HttpDelete]
        public IActionResult DeleteLevels(int id)
        {
            var value = _levelsService.TGetByID(id);
            _levelsService.TDelete(value);
            return Ok("Bütçe işlemi onaylanmadı.");
        }
        [HttpPut]
        public ILevelsService UpdateLevels(UpdateLevelsDto updateLevelsDto)
        {
            Levels levels = new Levels()
            {

                LevelID = updateLevelsDto.LevelID,
                ExpensesID = updateLevelsDto.ExpensesID,
                LevelNo = updateLevelsDto.LevelNo,


            };
            _levelsService.TUpdate(levels);

            return (ILevelsService)Ok("Bütçe onayı güncellendi.");

        }
        [HttpGet("GetLevels")]

        public IActionResult GetLevels(int id)
        {
            var value = _levelsService.TGetByID(id);
            return Ok(value);

        }
    }
}
