using simplyBooksBE.Models;

namespace simplyBooksBE.Interfaces
{
    public interface IAuthorsServices
    {
        Task<List<Authors>> GetAllAuthorsAsync();
        Task<List<Authors>> GetAuthorByIdAsync(int id);
        Task<Authors> CreateAuthorAsync(Authors author);
        Task<Authors> UpdateAuthorAsync(Authors author);
        Task<Authors> DeleteAuthorAsync(int id);
        Task<Authors> PostAuthorAsync(Authors author);

    }
}
