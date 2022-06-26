using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProjectDavitKldiashvili.Entities;

namespace MyProjectDavitKldiashvili.EntityConfigurations
{
    public class OrganizacionConfiguration : IEntityTypeConfiguration<Organizacion>
    {
        public void Configure(EntityTypeBuilder<Organizacion> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
