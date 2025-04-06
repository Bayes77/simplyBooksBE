using Microsoft.EntityFrameworkCore;
using simplyBooksBE.Interfaces;
using simplyBooksBE.Models;
using simplyBooksBE.Data;

namespace simplyBooksBE.Repositories
{
    public class AuthorsRepository : IAuthorsRepository
    {
        private readonly simplyBooksBEDbContext _context;

        public AuthorsRepository(simplyBooksBEDbContext context)
        {
            _context = context;
        }

        public async Task<List<Authors>> GetAllAuthorsAsync()
        {
            return await _context.Authors.ToListAsync();
        }

        public async Task<List<Authors>> GetAuthorByIdAsync(int id)
        {
            return await _context.Authors.Where(a => a.ID == id).ToListAsync();
        }

        public async Task<Authors> CreateAuthorAsync(Authors author)
        {
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();
            return author;
        }

        public async Task<Authors> UpdateAuthorAsync(int id, Authors author)
        {
            var existingAuthor = await _context.Authors.FindAsync(id);
            if (existingAuthor == null)
            {
                return null;
            }
            existingAuthor.First_Name = author.First_Name;
            existingAuthor.Last_Name = author.Last_Name;
            existingAuthor.Email = author.Email;
            existingAuthor.Favorite = author.Favorite;
            existingAuthor.ImageUrl = author.ImageUrl;
            await _context.SaveChangesAsync();
            return author;
        }

        public async Task<Authors> DeleteAuthorAsync(int id)
        {
            var author = await _context.Authors.FindAsync(id);
            if (author != null)
            {
                _context.Authors.Remove(author);
                await _context.SaveChangesAsync();
            }
            return author;
        }

        public async Task<Authors> PostAuthorAsync(Authors author)
        {
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();
            return author;
        }
    }
}
