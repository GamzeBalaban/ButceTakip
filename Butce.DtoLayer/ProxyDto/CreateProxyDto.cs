using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.DtoLayer.ProxyDto
{
    public class CreateProxyDto
    {
        public int ProxyID { get; set; }

        public string ProxyName { get; set; }

        public string PersonelTask { get; set; }
        public int RoleID { get; set; }
    }
}
