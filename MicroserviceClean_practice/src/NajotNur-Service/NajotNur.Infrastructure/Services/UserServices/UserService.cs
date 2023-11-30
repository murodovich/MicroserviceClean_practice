using NajotNur.Application.Repositories.UserRepositories;
using NajotNur.Domain.Entities.Models;
using NajotNur.Infrastructure.Dtos;

namespace NajotNur.Infrastructure.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ValueTask<int> Create(UserDto dto)
        {
            User user = new User();
            user.UserName = dto.UserName;
            user.Password = dto.Password;
            user.Email = dto.Email;
            user.LastName = dto.LastName;
            user.FirstName = dto.FirstName;

            var result = _userRepository.CreateAsync(user);
            return result;
        }

        public ValueTask<int> Delete(int id)
        {
            var result = _userRepository.DeleteAsync(id);
            return result;
        }

        public ValueTask<IList<User>> GetAll()
        {
            var result = _userRepository.GetAllAsync();
            return result;
        }

        public ValueTask<User> GetById(int id)
        {
            var result = _userRepository.GetByIdAsync(id);
            return result;
        }

        public ValueTask<int> Update(int id, UserDto dto)
        {
            User user = new User();
            user.UserName = dto.UserName;
            user.Password = dto.Password;
            user.Email = dto.Email;
            user.LastName = dto.LastName;
            user.FirstName = dto.FirstName;
            var result = _userRepository.UpdateAsync(id, user);
            return result;
        }

        
    }
}
