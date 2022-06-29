using MyProjectDavitKldiashvili;
using MyProjectDavitKldiashvili.Interfaces;
using MyProjectDavitKldiashvili.Models;

namespace MyProjectDavitKldiashvili.Mapping
{
    public class OrganizationMapper : IMapper<Entities.Organization, OrganizationModel>
    {
        public OrganizationModel MapFromEntityToModel(Entities.Organization source) => new OrganizationModel
        {

            Name = source.Name,
            Adress = source.Adress,
            ParentOrganization = source.ParentOrganization,
            Id = source.Id,


        };

        public Entities.Organization MapFromModelToEntity(OrganizationModel source)
        {
            var entity = new Entities.Organization();

            MapFromModelToEntity(source, entity);

            return entity;
        }

        public void MapFromModelToEntity(OrganizationModel source, Entities.Organization target)
        {
            target.Name = source.Name;
            target.Adress = source.Adress;
            target.ParentOrganization = source.ParentOrganization;
            target.Id = source.Id;
        }
    }
}