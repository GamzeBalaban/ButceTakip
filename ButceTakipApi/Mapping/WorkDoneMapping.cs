using Butce.DtoLayer.AppControlDto;
using Butce.DtoLayer.ApprovalDto;
using Butce.DtoLayer.WorkDoneDto;
using Butce.DtoLayer.LoginDto;
using Butce.EntityLayer.Entities;
using AutoMapper;
using Butce.DtoLayer.VATDto;


namespace ButceTakipApi.Mapping
{
    public class WorkDoneMapping:Profile
    {
        public WorkDoneMapping()
        {
            CreateMap<WorkDone, ResultWorkDoneDto>().ReverseMap();
            CreateMap<WorkDone, CreateWorkDoneDto>().ReverseMap();

            CreateMap<WorkDone, GetWorkDoneDto>().ReverseMap();

            CreateMap<WorkDone, UpdateWorkDoneDto>().ReverseMap();
        }
    }
}
