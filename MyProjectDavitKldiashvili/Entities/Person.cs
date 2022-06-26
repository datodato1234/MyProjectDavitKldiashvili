using MyProjectDavitKldiashvili.Enums;


namespace MyProjectDavitKldiashvili.Entities
{
    public class Person
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Image { get; set; }

        public Languages Language { get; set; }

        public Guid PersonalNumber { get; set; }

        public Guid OrganizationId { get; set; }

        public Organizacion Organizacion { get; set; }

    }
}
