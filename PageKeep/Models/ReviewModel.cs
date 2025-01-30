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

        [Required]
        [MaxLength(500)]
        public string Content { get; set; }

        [Required]
        [MaxLength(100)]
        public string ReviewerName { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [ForeignKey("BookId")]
        public BookModel Book { get; set; }
    }
}