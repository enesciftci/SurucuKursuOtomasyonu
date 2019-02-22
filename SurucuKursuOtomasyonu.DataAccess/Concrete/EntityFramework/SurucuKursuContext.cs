using SurucuKursuOtomasyonu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurucuKursuOtomasyonu.DataAccess.Concrete.EntityFramework
{
   
   public class SurucuKursuContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<RegistrationSeason> Seasons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SurucuKursuContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }

    
}
