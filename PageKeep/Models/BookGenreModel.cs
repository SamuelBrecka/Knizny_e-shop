﻿namespace PageKeep.Models;

public class BookGenreModel
{
    public int BookId { get; set; }
    public BookModel Book { get; set; }

    public int GenreId { get; set; }
    public GenreModel Genre { get; set; }
}