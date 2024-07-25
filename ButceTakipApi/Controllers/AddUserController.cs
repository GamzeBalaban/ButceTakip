using Butce.BusinessLayer.Abstract;
using Butce.DtoLayer.AddUser;
using Butce.DtoLayer.AddUserDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AddUserController : ControllerBase
    {
        private readonly IAddUserService _adduserService;

        public AddUserController(IAddUserService adduserService)
        {
            _adduserService = adduserService;
        }
        [HttpGet]
        public IActionResult AddUserList()
        {
            var values = _adduserService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAddUser(CreateAddUserDto createAddUserDto)
        {
            AddUser adduser = new AddUser()
            {
                Mail = createAddUserDto.Mail,
                UserName = createAddUserDto.UserName,
                RoleID = createAddUserDto.RoleID,
                UserID = createAddUserDto.UserID,

            };

            _adduserService.TAdd(adduser);
            return Ok("Başarılı bir şekilde onaylandı");
        }
        [HttpDelete]
        public IActionResult DeleteAddUser(int id)
        {
            var value = _adduserService.TGetByID(id);
            _adduserService.TDelete(value);
            return Ok("Bütçe işlemi onaylanmadı.");
        }
        [HttpPut]
        public IAddUserService UpdateAddUser(UpdateAddUserDto updateAddUserDto)
        {
            AddUser adduser = new AddUser()
            {
                Mail = updateAddUserDto.Mail,
                UserName = updateAddUserDto.UserName,
                UserID = updateAddUserDto.UserID,
                RoleID = updateAddUserDto.RoleID,


            };
            _adduserService.TUpdate(adduser);

            return (IAddUserService)Ok("Bütçe onayı güncellendi.");

        }
        [HttpGet("GetAddUser")]

        public IActionResult GetAddUser(int id)
        {
            var value = _adduserService.TGetByID(id);
            return Ok(value);

        }


    }
}

