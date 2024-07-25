using Butce.BusinessLayer.Abstract;
using Butce.DtoLayer.RolesDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRolesService _rolesService;

        public RolesController(IRolesService rolesService)
        {
            _rolesService = rolesService;
        }
        [HttpGet]
        public IActionResult RolesList()
        {
            var values = _rolesService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateRoles(CreateRolesDto createRolesDto)
        {
            Roles roles = new Roles()
            {
                RoleID = createRolesDto.RoleID,
                PersonelState = createRolesDto.PersonelState,
                PersonelRoles = createRolesDto.PersonelRoles

            };
            _rolesService.TAdd(roles);
            return Ok("Rol Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteRoles(int id)
        {
            var value = _rolesService.TGetByID(id);
            _rolesService.TDelete(value);
            return Ok("Rol Silindi");


        }
        [HttpPut]
        public IActionResult UpdateRoles (UpdateRolesDto updateRolesDto)
        {
            Roles roles = new Roles()
            {
                RoleID = updateRolesDto.RoleID,
                PersonelRoles = updateRolesDto.PersonelRoles,
                PersonelState = updateRolesDto.PersonelState
            };
            _rolesService.TUpdate(roles);
            return Ok("Rol Güncellendi");
        }
        [HttpGet("GetRoles")]
        public IActionResult GetRoles(int id)
        {
            var value = _rolesService.TGetByID(id);
            return Ok(value);
        }

    }
}
