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

        public async Task<Books> UpdateBookAsync(int id, Books book)
        {
            var existingBook = await _context.Books.FindAsync(id);
            if (existingBook == null)
            {
                return null;
            }
            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Price = book.Price;
            existingBook.Sale = book.Sale;
            existingBook.ImageUrl = book.ImageUrl;
            existingBook.Description = book.Description;
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<Books> DeleteBookAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                return null;
            }
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return book;
        }

    }
}
