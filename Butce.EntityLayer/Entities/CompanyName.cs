﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class CompanyName
    {
        [Key]
        public int CompanyID { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyNames { get; set; }
    }
}