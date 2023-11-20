using System.ComponentModel.DataAnnotations;

namespace BaigorriaJuan.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Logo del Cine")]
        public string Logo { get; set; }
        [Display(Name = "Nombre del Cine")]
        public string Name { get; set; }
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
