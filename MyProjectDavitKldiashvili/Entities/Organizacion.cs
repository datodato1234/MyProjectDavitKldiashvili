using System.ComponentModel.DataAnnotations;

namespace MyProjectDavitKldiashvili.Entities
{
 
    public class Organizacion
    {
           public Guid Id { get; set; }

           [MaxLength(50)]
           public string Name { get; set; }

           public string Adress { get; set; }

           public Guid ParentId { get; set; }
    }       
}
