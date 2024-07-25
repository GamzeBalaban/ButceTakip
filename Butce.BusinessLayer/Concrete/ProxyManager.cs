using Butce.BusinessLayer.Abstract;
using Butce.DataAccessLayer.Abstract;
using Butce.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.BusinessLayer.Concrete
{
    public class ProxyManager : IProxyService
    {

        private readonly IProxyDal _proxyDal;

        public ProxyManager(IProxyDal proxyDal)
        {
            _proxyDal = proxyDal;
        }

        public void TAdd(Proxy entity)
        {
            _proxyDal.Add(entity);
        }

        public void TDelete(Proxy entity)
        {
            _proxyDal.Delete(entity);
        }

        public List<Proxy> TGetAll()
        {
            return _proxyDal.GetAll();
        }

        public Proxy TGetByID(int id)
        {
            return _proxyDal.GetByID(id);
        }

        public void TUpdate(Proxy entity)
        {
            _proxyDal.Update(entity);
        }
    }
}
