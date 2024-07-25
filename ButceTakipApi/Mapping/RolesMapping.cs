using AutoMapper;
using Butce.DtoLayer.RolesDto;
using Butce.EntityLayer.Entities;

namespace ButceTakipApi.Mapping
{
    public class RolesMapping:Profile
    {
        public RolesMapping()
        {
            CreateMap<Roles, ResultRolesDto>().ReverseMap();
            CreateMap<Roles, CreateRolesDto>().ReverseMap();

            CreateMap<Roles, GetRolesDto>().ReverseMap();
            CreateMap<Roles, UpdateRolesDto>().ReverseMap();






        }
    }
}
