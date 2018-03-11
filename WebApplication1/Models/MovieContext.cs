using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MovieContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Aktorzy> Aktorzy { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<RecenzjeFilmowe> RecenzjeFilmowe { get; set; }


    }
}