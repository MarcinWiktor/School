using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    class Stanowisko
    {
        [Key]
        public int StanowiskoId { get; set; }
        public string Name { get; set; }
        public ICollection<Zalogant> Zalogant { get; set; }
    }
}
