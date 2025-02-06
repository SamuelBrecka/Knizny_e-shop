using System.ComponentModel.DataAnnotations;

namespace PageKeep.Models.Entities

{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole Názov nemôže byť prázdne")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Pole Autor nemôže byť prázdne")]
        public string Author { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Cena nemôže byť záporná.")]
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public byte[]? ImageFile { get; set; }
        [Required(ErrorMessage = "Pole Popis nemôže byť prázdne")]
        public string Description { get; set; }
        public ICollection<BookGenreModel> BookGenres { get; set; }
    }
}
