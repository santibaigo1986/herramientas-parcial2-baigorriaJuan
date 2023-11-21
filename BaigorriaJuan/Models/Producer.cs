using BaigorriaJuan.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace BaigorriaJuan.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Foto de Perfil")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Nombre Completo")]
        public string FullName { get; set; }
        [Display(Name = "Biografia")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
