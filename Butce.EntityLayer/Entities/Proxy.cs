using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class Proxy
    {
        [Key]
        public int ProxyID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProxyName { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonelTask { get; set; }

        [Required]
        public int RoleID { get; set; }

        [ForeignKey("RoleID")]
        public virtual Roles Role { get; set; }
    }
}
