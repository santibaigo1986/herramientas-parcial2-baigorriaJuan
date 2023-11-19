using System.ComponentModel.DataAnnotations;

namespace BaigorriaJuan.Models
{
    public class Cine
    {
        [Key]
        public int Id { get; set; } 
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
