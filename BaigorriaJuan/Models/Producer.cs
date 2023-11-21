using BaigorriaJuan.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace BaigorriaJuan.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Foto de Perfil")]
        [Required(ErrorMessage = "Debe Agregar foto de perfil")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Nombre Completo")]
        [Required(ErrorMessage = "Debe Nombre Completo")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nombre Completo debe estar entre 3 y 50 caracteres")]
        public string FullName { get; set; }
        [Display(Name = "Biografia")]
        [Required(ErrorMessage = "Debe Agregar Biografia")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
