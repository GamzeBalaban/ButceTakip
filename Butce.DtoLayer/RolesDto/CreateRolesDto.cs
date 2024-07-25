using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.DtoLayer.RolesDto
{
   public class CreateRolesDto
    {
        public int RoleID { get; set; }

        public string PersonelRoles { get; set; }

        public bool PersonelState { get; set; }
    }
}
