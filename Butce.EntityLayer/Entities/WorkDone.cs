using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class WorkDone
    {
        [Key]
        public int WorkDoneID { get; set; }

        [Required]
        [StringLength(50)]
        public string WorkDoneName { get; set; }
    }
}
