using Butce.BusinessLayer.Abstract;
using Butce.DtoLayer.ProxyDto;
using Butce.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ButceTakipApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProxyController : ControllerBase
    {
        private readonly IProxyService _proxyService;

        public ProxyController(IProxyService proxyService)
        {
            _proxyService = proxyService;
        }
        [HttpGet]
        public IActionResult ProxyList()
        {
            var values = _proxyService.TGetAll();
            return Ok(values);

        }
        [HttpPost]
        public IActionResult CreateProxy(CreateProxyDto createProxyDto)
        {
            Proxy proxy = new Proxy()
            {
                ProxyID = createProxyDto.ProxyID,
                ProxyName = createProxyDto.ProxyName,
                RoleID = createProxyDto.RoleID,
                PersonelTask = createProxyDto.PersonelTask,
            };
            _proxyService.TAdd(proxy);
            return Ok("Vekalet Ataması Yapıldı");
        }
        [HttpDelete]
        public IActionResult DeleteProxy(int id )
        {
           var value=  _proxyService.TGetByID(id);
           _proxyService.TDelete(value);
            return Ok("Vekalet Verme Silindi(geri alındı)");
        }
        [HttpPut]
        public IActionResult UpdateProxy(UpdateProxyDto updateProxyDto)
        {
            Proxy proxy = new Proxy()
            {
                ProxyID = updateProxyDto.ProxyID,
                ProxyName = updateProxyDto.ProxyName,
                RoleID = updateProxyDto.RoleID,
                PersonelTask = updateProxyDto.PersonelTask,
            };
            _proxyService.TUpdate(proxy);
            return Ok("Vekalet İşlemi Güncellendi");

        }
        [HttpGet("GetProxy")]
        public IActionResult GetProxy(int id)
        {
            var value = _proxyService.TGetByID(id);
            return Ok(value);
        }
    }
}
