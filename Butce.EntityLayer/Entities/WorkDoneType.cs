using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{

    public class WorkDoneType
    {
        [Key]
        public int WorkDoneTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string WorkDoneTypeName { get; set; }
    }
}
