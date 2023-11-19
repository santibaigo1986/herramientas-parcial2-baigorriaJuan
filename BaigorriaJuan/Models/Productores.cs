using System.ComponentModel.DataAnnotations;

namespace BaigorriaJuan.Models
{
    public class Productores
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
