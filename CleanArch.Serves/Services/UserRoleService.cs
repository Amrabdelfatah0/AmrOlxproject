using Amrproject.Data;
using Amrproject.IRepo;
using Amrproject.Roles;

namespace Amrproject.Services
{
    public class UserRoleService : IUserRole
    {
        private readonly ApplicationDbContext dbContext;
        public UserRoleService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public Task<bool> Add(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public Task<UserRole> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserRole> Get()
        {
            throw new NotImplementedException();
        }

        public bool ISExist(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(UserRole entity)
        {
            throw new NotImplementedException();
        }
    }
}
