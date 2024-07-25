using AutoMapper;
using Butce.DtoLayer.AddUser;
using Butce.DtoLayer.AddUserDto;
using Butce.DtoLayer.ApprovalDto;
using Butce.EntityLayer.Entities;

namespace ButceTakipApi.Mapping
{
    public class AddUserMapping :Profile
    {

        public AddUserMapping()
        {
            CreateMap<AddUser, ResultAddUserDto>().ReverseMap();
            CreateMap<AddUser, CreateAddUserDto>().ReverseMap();

            CreateMap<AddUser, GetAddUserDto>().ReverseMap();

            CreateMap<AddUser, UpdateAddUserDto>().ReverseMap();
        }
    }
}
