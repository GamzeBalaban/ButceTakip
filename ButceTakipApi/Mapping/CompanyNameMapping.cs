using AutoMapper;
using Butce.DtoLayer.AddUser;
using Butce.DtoLayer.AddUserDto;
using Butce.DtoLayer.CompanyNameDto;
using Butce.EntityLayer.Entities;

namespace ButceTakipApi.Mapping
{
    public class CompanyNameMapping :Profile
    {

        public  CompanyNameMapping()
        {
            CreateMap<CompanyName, ResultCompanyNameDto>().ReverseMap();
            CreateMap<CompanyName, CreateCompanyNameDto>().ReverseMap();

            CreateMap<CompanyName, GetCompanyNameDto>().ReverseMap();

            CreateMap<CompanyName, UpdateCompanyNameDto>().ReverseMap();
        
    }
    }
}
