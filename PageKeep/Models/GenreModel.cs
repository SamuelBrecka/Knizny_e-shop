using System.ComponentModel.DataAnnotations;

namespace PageKeep.Models;

public class GenreModel
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<BookGenreModel> BookGenres { get; set; }
}