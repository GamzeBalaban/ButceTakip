using System.Net.Security;
using System.Runtime;
using AutoMapper;
using Butce.DtoLayer.AppControlDto;
using Butce.DtoLayer.ApprovalDto;
using Butce.DtoLayer.LevelsDto;
using Butce.DtoLayer.LoginDto;
using Butce.EntityLayer.Entities;

namespace ButceTakipApi.Mapping
{
    public class LevelsMapping :Profile
    {

        public LevelsMapping()
        {

            CreateMap<Levels, ResultLevelsDto>().ReverseMap();
            CreateMap<Levels, CreateLevelsDto>().ReverseMap();

            CreateMap<Levels, GetLevelsDto>().ReverseMap();

            CreateMap<Levels, UpdateLevelsDto>().ReverseMap();

        }
    }
}
