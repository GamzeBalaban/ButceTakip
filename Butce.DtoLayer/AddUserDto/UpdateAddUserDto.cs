﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.DtoLayer.AddUserDto
{
    public class UpdateAddUserDto
    {
        public string Mail { get; set; }


        public string UserName { get; set; }

        public string PersonelRoles { get; set; }

        public int UserID { get; set; }
        public int RoleID { get; set; }
    }
}
