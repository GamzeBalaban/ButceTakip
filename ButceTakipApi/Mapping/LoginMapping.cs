using System.Runtime;
using AutoMapper;
using Butce.DtoLayer.LoginDto;
using Butce.EntityLayer.Entities;
namespace ButceTakipApi.Mapping
{
    public class LoginMapping: Profile
    {
        public LoginMapping()
        {
            CreateMap<Login, ResultLoginDto>().ReverseMap();
            CreateMap<Login, CreateLoginDto>().ReverseMap();
            CreateMap<Login, GetLoginDto>().ReverseMap();
            CreateMap<Login, UpdateLoginDto>().ReverseMap();
        }
    }
}
