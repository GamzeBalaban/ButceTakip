using AutoMapper;
using Butce.DtoLayer.PlanningDto;
using Butce.EntityLayer.Entities;

namespace ButceTakipApi.Mapping
{
    public class PlanningMapping:Profile
    {
        public PlanningMapping()
        {
            CreateMap<Planning, ResultPlanningDto>().ReverseMap();
            CreateMap<Planning, CreatePlanningDto>().ReverseMap();
            CreateMap<Planning, GetPlanningDto>().ReverseMap();
            CreateMap<Planning, UpdatePlanningDto>().ReverseMap();



        }
    }
}
