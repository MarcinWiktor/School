using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class Odprawa
    {
        public int OdprawaId { get; set; }
        public int NumerBramki { get; set; }
        public ICollection<OdprawaPasazer> OdprawyPasazerow { get; set; }
    }
}
