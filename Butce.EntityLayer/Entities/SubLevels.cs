using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Butce.EntityLayer.Entities
{
    public class SubLevels
    {
        [Key]
        public int SubLevelID { get; set; }

        [Required]
        public int LevelID { get; set; }

        [Required]
        public int SubLevelNo { get; set; }

        [ForeignKey("LevelID")]
        public virtual Levels Level { get; set; }
    }
}
