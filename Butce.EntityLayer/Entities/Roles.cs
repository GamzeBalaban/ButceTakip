using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class Roles
    {
        [Key]
        public int RoleID { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonelRoles { get; set; }

        [Required]
        public bool PersonelState { get; set; }
    }
}
