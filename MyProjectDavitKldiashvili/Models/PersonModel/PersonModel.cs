using MyProjectDavitKldiashvili.Entities;
using MyProjectDavitKldiashvili.Enums;
using System.ComponentModel.DataAnnotations;

namespace MyProjectDavitKldiashvili.Models
{
    public class PersonModel
    {
        public Guid Id { get; set; }

        [MaxLength(20), MinLength(2)]
        public string Name { get; set; }

        [MaxLength(20), MinLength(2)]

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Image { get; set; }

        public Languages Language { get; set; }
        [StringLength(11)]

        public string PersonalNumber { get; set; }

        public Guid OrganizationId { get; set; }

        public Organization? Organization { get; set; }
    }
}