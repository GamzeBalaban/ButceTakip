using AutoMapper;
using Butce.DtoLayer.RefuseDto;
using Butce.EntityLayer.Entities;

namespace ButceTakipApi.Mapping
{
    public class RefuseMapping:Profile
    {

        public RefuseMapping()
        {
            CreateMap<Refuse, ResultRefuseDto>().ReverseMap();
            CreateMap<Refuse, GetRefuseDto>().ReverseMap();


        }
    }
}
