using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PageKeep.Models
{
    public class ReviewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public BookModel Book { get; set; } = null!;

        [ForeignKey("User")]
        public int UserId { get; set; }

        public UserAccount? User { get; set; }

        [Required(ErrorMessage = "Pole Recenzia nemôže byť prázdne")]
        [MaxLength(500)]
        public string Content { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? ReviewerName { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}