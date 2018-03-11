using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class Zalogant
    {
        public int ZalogantId { get; set; }
        public string Name { get; set; }
        [ForeignKey("Stanowisko")]
        public int StanowiskoId { get; set; }
        public virtual Stanowisko Stanowisko{ get; set; }
    }
}
