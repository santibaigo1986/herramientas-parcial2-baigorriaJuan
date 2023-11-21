using BaigorriaJuan.Data.Base;
using BaigorriaJuan.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaigorriaJuan.Models
{
    public class NewMovieVM1
    {
        [Display(Name = "Nombre de la Pelicula")]
        [Required(ErrorMessage = "Nombre es requerido required")]
        public string Name { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Descripcion es Obligatorio")]
        public string Description { get; set; }

        [Display(Name = "Precio en $")]
        [Required(ErrorMessage = "Precio es obligatorio")]
        public double Price { get; set; }

        [Display(Name = "URL")]
        [Required(ErrorMessage = "El URL es obligatorio")]
        public string ImageURL { get; set; }

        [Display(Name = "Inicio")]
        [Required(ErrorMessage = "Inicio es obligatorio")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Final")]
        [Required(ErrorMessage = "Final es obligatorio")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Seleccione Categoria")]
        [Required(ErrorMessage = "Categoria es obligatoria")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Seleccione actor(es)")]
        [Required(ErrorMessage = "Los actor(es) es obligatorio")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Seleccione Cine")]
        [Required(ErrorMessage = "Cine es Obligatorio")]
        public int CinemaId { get; set; }

        [Display(Name = "Seleccione Productor")]
        [Required(ErrorMessage = "Productor es obligatorio")]
        public int ProducerId { get; set; }
    }
}