﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}