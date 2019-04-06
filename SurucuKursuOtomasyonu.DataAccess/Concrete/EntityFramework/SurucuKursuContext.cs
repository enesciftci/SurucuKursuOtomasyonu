using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using SurucuKursuOtomasyonu.Entities.Concrete;

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

        public class
            AttorneyConfiguration : EntityTypeConfiguration<LicenceType>
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