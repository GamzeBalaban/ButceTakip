using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class VAT
    {
        [Key]
        public int VATID { get; set; }

        public int VATRate { get; set; }
    }
}
