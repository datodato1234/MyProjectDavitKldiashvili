using Microsoft.EntityFrameworkCore;
using MyProjectDavitKldiashvili.Entities;
using MyProjectDavitKldiashvili.EntityConfigurations;


namespace MyProjectDavitKldiashvili
{
    public class MyProjectDavitKldiashviliContext : DbContext
    {
        public DbSet<Organization> Organizaions { get; set; }
        public DbSet<Person> Persons { get; set; }
        public object Organizations { get; internal set; }

        public MyProjectDavitKldiashviliContext()
        {

        }


        public MyProjectDavitKldiashviliContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrganizationConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfigurations());
            
        }
    }
}