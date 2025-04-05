using Microsoft.EntityFrameworkCore;
using simplyBooksBE.Interfaces;
using simplyBooksBE.Models;
using simplyBooksBE.Data;


namespace simplyBooksBE.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private readonly simplyBooksBEDbContext _context;
        public BooksRepository(simplyBooksBEDbContext context)
        {
            _context = context;
        }
        public async Task<List<Books>> GetAllBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }
        public async Task<List<Books>> GetBookByIdAsync(int id)
        {
            return await _context.Books.Where(b => b.Id == id).ToListAsync();
        }

        public async Task<Books> CreateBookAsync(Books book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<Books> UpdateBookAsync(Books book)
        {
            _context.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<Books> DeleteBookAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
            return book;
        }

        public async Task<Books> PostBookAsync(Books book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

    }
}
