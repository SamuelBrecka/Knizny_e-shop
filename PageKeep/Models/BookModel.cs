using System.ComponentModel.DataAnnotations;

namespace PageKeep.Models
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Pole Názov nemôže byť prázdne")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Pole Autor nemôže byť prázdne")]
        public string Author { get; set; } = string.Empty;

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Cena nemôže byť záporná.")]
        public decimal Price { get; set; }

        public string? Image { get; set; } = null;

        public byte[]? ImageFile { get; set; } = null;

        [Required(ErrorMessage = "Pole Popis nemôže byť prázdne")]
        public string Description { get; set; } = string.Empty;

        public ICollection<BookGenreModel> BookGenres { get; set; } = new List<BookGenreModel>();
    }
}