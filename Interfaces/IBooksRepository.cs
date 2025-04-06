using simplyBooksBE.Models;

namespace simplyBooksBE.Interfaces
{
    public interface IBooksRepository
    {
        Task<List<Books>> GetAllBooksAsync();
        Task<List<Books>> GetBookByIdAsync(int id);
        Task<Books> CreateBookAsync(Books book);
        Task<Books> UpdateBookAsync(int id, Books book);
        Task<Books> DeleteBookAsync(int id);
  
    }
}
