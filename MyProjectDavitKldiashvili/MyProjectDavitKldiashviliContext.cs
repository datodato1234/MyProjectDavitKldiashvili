using Microsoft.EntityFrameworkCore;
using MyProjectDavitKldiashvili.Entities;
using MyProjectDavitKldiashvili.EntityConfigurations;


namespace MyProjectDavitKldiashvili
{
    public class MyProjectDavitKldiashviliContext : DbContext
    {
        public DbSet<Organizacion> Organizaions { get; set; }
        public DbSet<Person> Persons { get; set; }


        public MyProjectDavitKldiashviliContext()
        {

        }


        public MyProjectDavitKldiashviliContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrganizacionConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfigurations());
            
        }
    }

    
}