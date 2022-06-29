using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProjectDavitKldiashvili.Entities;

namespace MyProjectDavitKldiashvili.EntityConfigurations
{
    public class PersonConfigurations : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Organization);
        }
    }
}
