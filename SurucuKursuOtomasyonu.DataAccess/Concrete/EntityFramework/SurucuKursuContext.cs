using SurucuKursuOtomasyonu.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurucuKursuOtomasyonu.DataAccess.Concrete.EntityFramework
{

    public class SurucuKursuContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<RegistrationSeason> Seasons { get; set; }
        public DbSet<LicenceType> LicenceTypes { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SurucuKursuContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public partial class
            AttorneyConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<LicenceType>
        {
            public AttorneyConfiguration()
                : this("dbo")
            {
            }

            public AttorneyConfiguration(string schema)
            {
                ToTable(schema + ".LicenceTypes");
                HasKey(x => x.LicenceTypeId);

            }
        }


    }
}
