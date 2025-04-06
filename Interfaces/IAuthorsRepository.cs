using simplyBooksBE.Models;



namespace simplyBooksBE.Interfaces
{
    public interface IAuthorsRepository
    {
       Task<List<Authors>> GetAllAuthorsAsync();
        Task<List<Authors>> GetAuthorByIdAsync(int id);
        Task<Authors> CreateAuthorAsync(Authors author);
        Task<Authors> UpdateAuthorAsync(int id, Authors author);
        Task<Authors> DeleteAuthorAsync(int id);
    

    }
}
