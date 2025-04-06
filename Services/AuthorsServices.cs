using simplyBooksBE.Interfaces;
using simplyBooksBE.Models;

namespace simplyBooksBE.Services
{
    public class AuthorsServices : IAuthorsServices
    {
        private readonly IAuthorsRepository _authorsRepository;
        public AuthorsServices(IAuthorsRepository authorsRepository)
        {
            _authorsRepository = authorsRepository;
        }
        public async Task<List<Authors>> GetAllAuthorsAsync()
        {
            return await _authorsRepository.GetAllAuthorsAsync();
        }
        public async Task<List<Authors>> GetAuthorByIdAsync(int id)
        {
            return await _authorsRepository.GetAuthorByIdAsync(id);
        }
        public async Task<Authors> CreateAuthorAsync(Authors author)
        {
            return await _authorsRepository.CreateAuthorAsync(author);
        }
        public async Task<Authors> UpdateAuthorAsync(int id, Authors author)
        {
            return await _authorsRepository.UpdateAuthorAsync(id, author);
        }
        public async Task<Authors> DeleteAuthorAsync(int id)
        {
            return await _authorsRepository.DeleteAuthorAsync(id);
        }
      
    }
}
