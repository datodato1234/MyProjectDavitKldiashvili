using MyProjectDavitKldiashvili.Interfaces;
using MyProjectDavitKldiashvili.Mapping;
using MyProjectDavitKldiashvili.Models;
using Microsoft.EntityFrameworkCore;
using FinalProject_KhatiashviliGoga.Models;

namespace MyProjectDavitKldiashvili.Services
{


    public class CreatePersonModel : IPersonService
    {
        private readonly MyProjectDavitKldiashviliContext _context;
        private readonly IMapper<Entities.Person, PersonModel> _personMapper;

        public CreatePersonModel(MyProjectDavitKldiashviliContext context)
        {
            _personMapper = new PersonMapper();
            _context = context;
        }

        public CreatePersonModel(PersonModel person)
        {
            var personAlreadyExists = _context.Persons.Any(p => p.Id == person.Id);

            if (personAlreadyExists)
            {
                throw new DbUpdateException($"person with id '{person.Id}' already exist.");
            }

            var personEntity = _personMapper.MapFromModelToEntity(person);

            var newPerson = _context.Persons.Add(personEntity);

            _context.SaveChanges();

            new CreatePersonResponse { CreatedPerson = person };
        }

        public GetPersonResponse GetPerson(GetPersonRequest getPersonRequest)
        {
            var person = _context.Persons.Find(getPersonRequest.Id); // get from base, we have entity type object
            var personModel = _personMapper.MapFromEntityToModel(person); // using mapper to get category Model
            var response = new GetPersonResponse { Person = personModel };

            return response;

        }


        public UpdatePersonResponse UpdatePerson(UpdatePersonRequest updatePersonRequest)
        {
            var existingPersonToUpdate = _context.Persons.Find(updatePersonRequest.PersonToUpdate.Id);

            if (existingPersonToUpdate == null)
            {
                throw new DbUpdateException($"Person with Id {updatePersonRequest.PersonToUpdate.Id} does not exist ");
            }

            _personMapper.MapFromModelToEntity(updatePersonRequest.PersonToUpdate, existingPersonToUpdate);
            _context.SaveChanges();

            return new UpdatePersonResponse { UpdatedPerson = updatePersonRequest.PersonToUpdate };
        }

        public DeletePersonResponse DeletePerson(DeletePersonRequest deletePersonRequest)
        {
            var personToDelete = _context.Persons.Find(deletePersonRequest.Id);
            if (personToDelete == null)
            {
                throw new DbUpdateException($"Person with id '{deletePersonRequest.Id}' doesn't exist.");
            }

            _context.Persons.Remove(personToDelete);
            _context.SaveChanges();

            return new DeletePersonResponse();
        }



        public IEnumerable<PersonModel> GetPersons()
        {
            var persons = new List<PersonModel>();
            foreach (var item in _context.Persons)
            {
                persons.Add(_personMapper.MapFromEntityToModel(item));
            }

            return persons;
        }

        public CreatePersonResponse CreatePerson(PersonModel request)
        {
            throw new NotImplementedException();
        }
    }

}