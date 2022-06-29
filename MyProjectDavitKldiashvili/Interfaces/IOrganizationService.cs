using M.Models;
using MyProjectDavitKldiashvili.Entities;
using MyProjectDavitKldiashvili.Models;

namespace FinalProject_KhatiashviliGoga.Interfaces
{
    public interface IOrganizationService
    {
        IEnumerable<OrganizationModel> GetOrganizations();
        GetOrganizationResponse GetOrganization(GetOrganizationRequest request);
        CreateOrganizationResponse CreateOrganization(OrganizationModel request);

        UpdateOrganizationResponse UpdateOrganization(UpdateOrganizationRequest request);
        DeleteOrganizationResponse DeleteOrganization(DeleteOrganizationRequest request);
    }
}
