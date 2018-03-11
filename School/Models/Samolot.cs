using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Samolot
    {
        public int SamolotId { get; set; }

        [Required]
        [Column(TypeName = "char")]
        [StringLength(5)]
        public string NrSeryjny { get; set; }

        [ForeignKey("TypSamolotu")]
        public int TypId { get; set; }

        public virtual TypSamolotu TypSamolotu { get; set; }
    }
}
