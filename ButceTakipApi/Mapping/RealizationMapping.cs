using AutoMapper;
using Butce.DtoLayer.RealizationDto;
using Butce.EntityLayer.Entities;

namespace ButceTakipApi.Mapping
{
    public class RealizationMapping :Profile
    {
        public RealizationMapping()
        {
            CreateMap<Realization, ResultRealizationDto>().ReverseMap();
            CreateMap<Realization, UpdateRealizationDto>().ReverseMap();

            CreateMap<Realization, GetRealizationDto>().ReverseMap();


        }
    }
}
