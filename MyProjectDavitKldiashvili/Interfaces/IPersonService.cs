using FinalProject_KhatiashviliGoga.Models;
using MyProjectDavitKldiashvili.Entities;
using MyProjectDavitKldiashvili.Models;



namespace MyProjectDavitKldiashvili.Interfaces
{
    public interface IPersonService
    {
        IEnumerable<PersonModel> GetPersons();
        GetPersonResponse GetPerson(GetPersonRequest request);
        CreatePersonResponse CreatePerson(PersonModel request);

        UpdatePersonResponse UpdatePerson(UpdatePersonRequest request);
        DeletePersonResponse DeletePerson(DeletePersonRequest request);
    }
}