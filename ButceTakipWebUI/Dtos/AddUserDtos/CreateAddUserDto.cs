﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButceTakipWebUI.Dtos.AddUserDtos
{
    public class CreateAddUserDto
    {
        public string Mail { get; set; }


        public string UserName { get; set; }

        public string PersonelRoles { get; set; }

        public int UserID { get; set; }
        public int RoleID { get; set; }
        public bool Status { get; internal set; }
    }
}