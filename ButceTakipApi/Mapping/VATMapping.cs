using Butce.DtoLayer.AppControlDto;
using Butce.DtoLayer.ApprovalDto;
using Butce.DtoLayer.VATDto;
using Butce.DtoLayer.LoginDto;
using Butce.EntityLayer.Entities;
using AutoMapper;


namespace ButceTakipApi.Mapping
{
    public class VATMapping:Profile
    {
        public VATMapping()
        {
            CreateMap<VAT, ResultVATDto>().ReverseMap();
            CreateMap<VAT, CreateVATDto>().ReverseMap();

            CreateMap<VAT, GetVATDto>().ReverseMap();

            CreateMap<VAT, UpdateVATDto>().ReverseMap();
        }

    }
}
