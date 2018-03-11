using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class OdprawaPasazer
    {
        [Key]
        [Column(Order = 0)]
        public int OdprawaId { get; set; }
        [ForeignKey("Pasazer")]
        [Key]
        [Column(Order = 1)]
        public string Pesel { get; set; }
        public bool Bagaz { get; set; }
        public int WagaBagazu { get; set; }
        public DateTime CzasOdprawy { get; set; }
        public Odprawa Odprawa { get; set; }
        public Pasazer Pasazer { get; set; }
    }
}
