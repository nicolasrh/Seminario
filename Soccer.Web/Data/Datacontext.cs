using Microsoft.EntityFrameworkCore;
using Soccer.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soccer.Web.Data
{
    public class Datacontext :DbContext 
    {
        public Datacontext(DbContextOptions<Datacontext> options) : base(options)
        {
        }
        public DbSet<TeamEntity> Teams { get; set; }
    }
}
 