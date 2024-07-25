using AutoMapper;
using Butce.DtoLayer.ProxyDto;
using Butce.EntityLayer.Entities;

namespace ButceTakipApi.Mapping
{
    public class ProxyMapping :Profile
    {
        public ProxyMapping()
        {
            CreateMap<Proxy, ResultProxyDto>().ReverseMap();
            CreateMap<Proxy, CreateProxyDto>().ReverseMap();

            CreateMap<Proxy, GetProxyDto>().ReverseMap();

            CreateMap<Proxy, UpdateProxyDto>().ReverseMap();

        }
    }
}
