using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MudrakPatel_Comp306_Assignment3.Data
{
    public class MovieContext : DbContext
    {
        //Parameterless constructor
        public MovieContext()
            : base()
        {
        }
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<MudrakPatel_Comp306_Assignment3.Models.Movie> Movie { get; set; }
    }

}
