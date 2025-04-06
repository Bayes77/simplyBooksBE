using simplyBooksBE.Interfaces;
using simplyBooksBE.Models;

namespace simplyBooksBE.Services
{
    public class BooksService : IBooksServices
    {
        private readonly IBooksRepository _booksRepository;

        public BooksService(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public async Task<List<Books>> GetAllBooksAsync()
        {
            return await _booksRepository.GetAllBooksAsync();
        }

        public async Task<List<Books>> GetBookByIdAsync(int id)
        {
            return await _booksRepository.GetBookByIdAsync(id);
        }

        public async Task<Books> CreateBookAsync(Books book)
        {
            return await _booksRepository.CreateBookAsync(book);
        }

        public async Task<Books> UpdateBookAsync(int id, Books book)
        {
            return await _booksRepository.UpdateBookAsync(id,book);
        }

        public async Task<Books> DeleteBookAsync(int id)
        {
            return await _booksRepository.DeleteBookAsync(id);
        }

       

    }
}
