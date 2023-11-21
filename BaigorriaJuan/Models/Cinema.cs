using BaigorriaJuan.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace BaigorriaJuan.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Logo del Cine")]
        
        [Required(ErrorMessage = "El logo del Cine es requerido")]
        public string Logo { get; set; }
        [Display(Name = "Nombre del Cine")]
        [Required(ErrorMessage = "El nombre del Cine es requerido")]
        public string Name { get; set; }
        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "La descripcion del Cine es requerida")]
        public string Description { get; set; }

        //Relationships
        public List<NewMovieVM> Movies { get; set; }
    }
}
