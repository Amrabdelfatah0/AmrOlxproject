using Amrproject.Data;
using Amrproject.IRepo;
using Amrproject.Models.Communication;

namespace Amrproject.Services
{
    public class MobileService : IMobile
    {
        private readonly ApplicationDbContext dbContext;
        public MobileService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public Task<bool> Add(Mobile entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Mobile entity)
        {
            throw new NotImplementedException();
        }

        public Task<Mobile> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Mobile> Get()
        {
            throw new NotImplementedException();
        }

        public List<Mobile> GetAll(int UserId)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(string Mobile)
        {
            throw new NotImplementedException();
        }

        public bool ISExist(Mobile entity)
        {
            throw new NotImplementedException();
        }

        public bool IsUserHasMobile(int UserId)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(Mobile entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Mobile entity)
        {
            throw new NotImplementedException();
        }
    }
}
