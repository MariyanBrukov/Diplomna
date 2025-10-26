using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(100)]
        public string Subject { get; set; }

        [Required]
        [StringLength(500)]
        public string Message { get; set; }
    }
}
