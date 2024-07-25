using AutoMapper;
using Butce.DtoLayer.ApprovalDto;
using Butce.EntityLayer.Entities;

namespace ButceTakipApi.Mapping
{
    public class ApprovalMapping:Profile
    {
        public ApprovalMapping()
        {
            CreateMap<Approval, ResultApprovalDto>().ReverseMap();
            CreateMap<Approval, CreateApprovalDto>().ReverseMap();

            CreateMap<Approval, GetApprovalDto>().ReverseMap();

            CreateMap<Approval, UpdateApprovalDto>().ReverseMap();

        }
    }
}
