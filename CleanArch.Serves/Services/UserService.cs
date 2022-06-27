using Amrproject.Data;
using Amrproject.IRepo;
using Amrproject.Models;

namespace Amrproject.Services
{
    public class UserService : IUser
    {
        private readonly ApplicationDbContext dbContext;
        public UserService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public Task<bool> Add(User entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public bool IsExist(int Id)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        public bool IsPasswordMatch(string Password, string ConfirmPassword)
        {
            throw new NotImplementedException();
        }

        public bool IsUserNameExist(string UserName)
        {
            throw new NotImplementedException();
        }

        public bool IsUserValidate(User entity, bool IsUpdate = false)
        {
            throw new NotImplementedException();
        }

        public User LogIn(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
