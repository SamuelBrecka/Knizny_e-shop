﻿using Microsoft.EntityFrameworkCore;
using PageKeep.dbcontext;
using PageKeep.Models;

namespace PageKeep.Services
{
    public class BookService
    {
        private readonly AppDbContext _dbContext;

        public BookService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BookModel>> GetAllBooksAsync()
        {
            return await _dbContext.Books
                .Include(b => b.BookGenres)
                .ThenInclude(bg => bg.Genre)
                .ToListAsync();
        }

        public async Task<BookModel?> GetBookByIdAsync(int id)
        {
            return await _dbContext.Books
                .Include(b => b.BookGenres)
                .ThenInclude(bg => bg.Genre)
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<BookGenreModel>> GetBookGenresById(int bookId)
        {
            return await _dbContext.BookGenres.Where(bg => bg.BookId == bookId).ToListAsync();
        }

        public async Task AddBookAsync(BookModel? book)
        {
            if (book != null) _dbContext.Books.Add(book);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateBookAsync(BookModel book)
        {
            _dbContext.Entry(book).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await _dbContext.Books.FindAsync(id);
            if (book != null)
            {
                _dbContext.Books.Remove(book);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}