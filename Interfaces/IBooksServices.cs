using simplyBooksBE.Models;

namespace simplyBooksBE.Interfaces
{
    public interface IBooksServices
    {
        Task<List<Books>> GetAllBooksAsync();
        Task<List<Books>> GetBookByIdAsync(int id);
        Task<Books> CreateBookAsync(Books book);
        Task<Books> UpdateBookAsync(Books book);
        Task<Books> DeleteBookAsync(int id);
        Task<Books> PostBookAsync(Books book);
    }
}
