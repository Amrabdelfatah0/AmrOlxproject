using Amrproject.Data;
using Amrproject.IRepo;
using Amrproject.Models.Location;

namespace Amrproject.Services
{
    public class GovernroteService : IGovernroteRepo
    {
        private readonly ApplicationDbContext dbContext;
        public GovernroteService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public Task<bool> Add(Governrote entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Governrote entity)
        {
            throw new NotImplementedException();
        }

        public Task<Governrote> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Governrote> Get()
        {
            throw new NotImplementedException();
        }

        public bool ISExist(Governrote entity)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(Governrote entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Governrote entity)
        {
            throw new NotImplementedException();
        }
    }
}
