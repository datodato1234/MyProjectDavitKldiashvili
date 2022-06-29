using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProjectDavitKldiashvili.Entities;

namespace MyProjectDavitKldiashvili.EntityConfigurations
{
    public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
