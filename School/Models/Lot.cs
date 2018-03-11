using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class Lot
    {
        public int LotId { get; set; }
        public int Numer { get; set; }
        public DateTime DataPrzylotu { get; set; }
        public DateTime DataOdlotu { get; set; }
        public int KierunekId { get; set; }
        [ForeignKey("KierunekId")]
        public virtual Kierunek Kierunek { get; set; }
        public int SamolotId { get; set; }
        [ForeignKey("SamolotId")]
        public virtual Samolot Samolot { get; set; }
    }
}
