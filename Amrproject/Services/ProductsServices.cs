using Amrproject.Data;
using Amrproject.IRepo;
using Amrproject.Models;

namespace Amrproject.Services
{
    public class ProductsServices : IProductsClassRepository

    {
        private readonly ApplicationDbContext dbContext;
        public ProductsServices(ApplicationDbContext _dbContext) 
        {
            dbContext = _dbContext;
        }
        public async Task<bool> Add(Products entity)

        {
            if (IsValid(entity) && !ISExist(entity))
            {
                entity.CreatedDate = entity.LastModifiedDate = DateTime.Now;
                dbContext.Products.Add(entity);
                await dbContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }



        }

        public Task Delete(Products entity)
        {
            throw new NotImplementedException();
        }

        public Task<Products> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Products> Get()
        {
            throw new NotImplementedException();
        }

        public bool ISExist(Products entity)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(Products entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Products entity)
        {
            throw new NotImplementedException();
        }


        public bool IsExist(Products entity)
        {
            return dbContext.Products.Any(x => x.Id == entity.Id);
        }

        public bool IsValid(Products entity)
        {
            return true;
        }
    }




}
