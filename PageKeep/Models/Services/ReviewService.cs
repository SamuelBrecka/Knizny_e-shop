using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PageKeep.dbcontext;
using PageKeep.Models.Entities;

namespace PageKeep.Models.Services
{
    public class ReviewService
    {
        private readonly AppDbContext _dbContext;

        public ReviewModel NewReview { get; set; } = new();

        public ReviewService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ReviewModel>> GetReviewsAsync(int bookId)
        {
            return await _dbContext.Reviews
                .Where(r => r.BookId == bookId)
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync();
        }

        public async Task AddReviewAsync(ReviewModel review)
        {
            _dbContext.Reviews.Add(review);
            await _dbContext.SaveChangesAsync();
        }

        public async Task EditReviewAsync(int reviewId, string newContent, int userId)
        {
            var review = await _dbContext.Reviews.FindAsync(reviewId);
            if (review == null || review.UserId != userId) return;

            review.Content = newContent;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteReviewAsync(int reviewId)
        {
            var review = await _dbContext.Reviews.FindAsync(reviewId);

            _dbContext.Reviews.Remove(review);
            await _dbContext.SaveChangesAsync();
        }
    }
}
