using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WADCenima.Areas.Admin.Models;
using WADCenima.Areas.Admin.Models.Entity;

namespace WADCinema.Areas.Admin.Models.BusinessModel
{
    public class CinemaManagementContext:DbContext
    {
        public CinemaManagementContext(DbContextOptions<CinemaManagementContext> options):base(options)
        {

        }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<User> users { get; set; }
    }
}
