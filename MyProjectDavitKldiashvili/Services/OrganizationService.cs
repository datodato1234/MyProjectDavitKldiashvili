using MyProjectDavitKldiashvili.Entities;
using MyProjectDavitKldiashvili.Interfaces;
using MyProjectDavitKldiashvili.Mapping;
using MyProjectDavitKldiashvili.Models;
using Microsoft.EntityFrameworkCore;
using MyProjectDavitKldiashvili;
using FinalProject_KhatiashviliGoga.Interfaces;
using M.Models;

namespace FinalProject_KhatiashviliGoga.Services
{
    public class OrganizationService : IOrganizationService
    {
        private readonly MyProjectDavitKldiashviliContext _context;
        private readonly IMapper<MyProjectDavitKldiashvili.Entities.Organization, OrganizationModel> _organizationMapper;

        public OrganizationService(MyProjectDavitKldiashviliContext context)
        {
            _organizationMapper = new OrganizationMapper();
            _context = context;
        }

        public CreateOrganizationResponse CreateOrganization(OrganizationModel organization)
        {
            var organizationAlreadyExists = _context.Organizations.Any(p => p.Id == organization.Id);

            if (organizationAlreadyExists)
            {
                throw new DbUpdateException($"Organization with id '{organization.Id}' already exist.");
            }

            var organizationEntity = _organizationMapper.MapFromModelToEntity(organization);

            var newOrganization = _context.Organizations.Add(organizationEntity);

            _context.SaveChanges();

            return new CreateOrganizationResponse { CreatedOrganization = organization };
        }

        public GetOrganizationResponse GetOrganization(GetOrganizationRequest getOrganizationRequest)
        {
            var organization = _context.Organizations.Find(getOrganizationRequest.Id); // get from base, we have entity type object
            var organizationModel = _organizationMapper.MapFromEntityToModel(organization); // using mapper to get category Model
            var response = new GetOrganizationResponse { Organization = organizationModel };

            return response;
        }


        public UpdateOrganizationResponse UpdateOrganization(UpdateOrganizationRequest updateOrganizationRequest)
        {
            var existingOrganizationToUpdate = _context.Organizations.Find(updateOrganizationRequest.OrganizationToUpdate.Id);

            if (existingOrganizationToUpdate == null)
            {
                throw new DbUpdateException($"Organization with Id {updateOrganizationRequest.OrganizationToUpdate.Id} does not exist ");
            }

            _organizationMapper.MapFromModelToEntity(updateOrganizationRequest.OrganizationToUpdate, existingOrganizationToUpdate);
            _context.SaveChanges();

            return new UpdateOrganizationResponse { UpdatedOrganization = updateOrganizationRequest.OrganizationToUpdate };
        }

        public DeleteOrganizationResponse DeleteOrganization(DeleteOrganizationRequest deleteOrganizationRequest)
        {
            var organizationToDelete = _context.Organizations.Find(deleteOrganizationRequest.Id);
            if (organizationToDelete == null)
            {
                throw new DbUpdateException($"Organization with id '{deleteOrganizationRequest.Id}' doesn't exist.");
            }

            _context.Organizations.Remove(organizationToDelete);
            _context.SaveChanges();

            return new DeleteOrganizationResponse();
        }

        public IEnumerable<OrganizationModel> GetOrganizations()
        {
            throw new NotImplementedException();
        }

        CreateOrganizationResponse IOrganizationService.CreateOrganization(OrganizationModel request)
        {
            throw new NotImplementedException();
        }
    }
}
