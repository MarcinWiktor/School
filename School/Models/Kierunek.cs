using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class Kierunek
    {
        public int KierunekId { get; set; }
        public string MiejsceOdlotu { get; set; }
        public string MiejscePrzylotu { get; set; }

        public virtual ICollection<Lot> Lots { get; set; }
    }
}
