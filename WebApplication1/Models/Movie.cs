using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int YearOfRelease { get; set; }

        public ICollection<Genre> Genres { get; set; }
    }
}