using System.Net.Security;
using System.Runtime;
using AutoMapper;
using Butce.DtoLayer.AppControlDto;
using Butce.DtoLayer.LoginDto;
using Butce.EntityLayer.Entities;


namespace ButceTakipApi.Mapping
{
    public class AppControlMapping :Profile
    {
        public AppControlMapping()
        {
            CreateMap<AppControl, ResultAppControlDto>().ReverseMap();
            CreateMap<AppControl, CreateAppControlDto>().ReverseMap();
            CreateMap<AppControl, GetAppControlDto>().ReverseMap();
           
        }
    }
}
