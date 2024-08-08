using System.ComponentModel.DataAnnotations;

namespace MusicApp.Models
{
    public class Music
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }=string.Empty;

        [Required]
        [StringLength(50)]
        public string Artist { get; set; }=string.Empty;

        [Required]
        [StringLength(100)]
        public string Album { get; set; }=string.Empty;

        [Required]
        public int Year { get; set; }
    }
}
