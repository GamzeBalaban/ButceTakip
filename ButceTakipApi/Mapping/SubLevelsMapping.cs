
using Butce.DtoLayer.AppControlDto;
using Butce.DtoLayer.ApprovalDto;
using Butce.DtoLayer.SubLevelsDto;
using Butce.DtoLayer.LoginDto;
using Butce.EntityLayer.Entities;
using AutoMapper;
namespace ButceTakipApi.Mapping
{
    public class SubLevelsMapping:Profile
    {

        public SubLevelsMapping() {

            CreateMap<SubLevels, ResultSubLevelsDto>().ReverseMap();
            CreateMap<SubLevels, CreateSubLevelsDto>().ReverseMap();

            CreateMap<SubLevels, GetSubLevelsDto>().ReverseMap();

            CreateMap<SubLevels, UpdateSubLevelsDto>().ReverseMap();
        }
    }
}
