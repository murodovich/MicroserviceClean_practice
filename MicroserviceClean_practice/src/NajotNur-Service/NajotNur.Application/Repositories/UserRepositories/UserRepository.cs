using Microsoft.EntityFrameworkCore;
using NajotNur.Application.Data;
using NajotNur.Domain.Entities.Models;

namespace NajotNur.Application.Repositories.UserRepositories
{
    public class UserRepository : IUserRepository
    {
        private readonly NajotNurDBContext _dbContext;

        public UserRepository(NajotNurDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async ValueTask<int> CreateAsync(User user)
        {
            await _dbContext.users.AddAsync(user);
            var result = await _dbContext.SaveChangesAsync();
            return result;
        }



        public async ValueTask<int> DeleteAsync(int id)
        {
            var result = await _dbContext.users.FirstOrDefaultAsync(x => x.UserId == id);

            _dbContext.users.Remove(result);
            var res = await _dbContext.SaveChangesAsync();
            return res;

        }

        public async ValueTask<IList<User>> GetAllAsync()
        {
            var result = await _dbContext.users.ToListAsync();
            return result;
        }

        public async ValueTask<User> GetByIdAsync(int id)
        {
            var result = await _dbContext.users.FirstOrDefaultAsync(x => x.UserId == id);
            return result;
        }

        public async ValueTask<int> UpdateAsync(int Id, User user)
        {
            var result = await _dbContext.users.FirstOrDefaultAsync(x => x.UserId == Id);
            _dbContext.users.Update(result);

            var res = await _dbContext.SaveChangesAsync();
            return res;
        }
    }
}
