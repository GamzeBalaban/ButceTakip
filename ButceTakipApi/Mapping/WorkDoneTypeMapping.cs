using AutoMapper;
using Butce.DtoLayer.VATDto;
using Butce.DtoLayer.WorkDoneTypeDto;
using Butce.EntityLayer.Entities;

namespace ButceTakipApi.Mapping
{
    public class WorkDoneTypeMapping:Profile
    {

        public WorkDoneTypeMapping()
        {

            CreateMap<WorkDoneType, ResultWorkDoneTypeDto>().ReverseMap();
            CreateMap<WorkDoneType, CreateWorkDoneTypeDto>().ReverseMap();

            CreateMap<WorkDoneType, GetWorkDoneTypeDto>().ReverseMap();

            CreateMap<WorkDoneType, UpdateWorkDoneTypeDto>().ReverseMap();
        }
    }
}
