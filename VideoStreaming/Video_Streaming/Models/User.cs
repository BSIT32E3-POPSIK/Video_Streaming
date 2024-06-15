using System.ComponentModel.DataAnnotations;

namespace Video_Streaming.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public List<string>? VideosWatched { get; set; }
    }
}
