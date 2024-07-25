using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.DtoLayer.LoginDto
{
    public class GetLoginDto
    {
        public int LoginId { get; set; }

        public string Mail { get; set; }

        public string Password { get; set; }
    }
}
