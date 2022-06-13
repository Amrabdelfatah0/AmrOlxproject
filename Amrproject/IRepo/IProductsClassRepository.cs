using Amrproject.Models;

namespace Amrproject.IRepo
{
    public interface IProductsClassRepository : IGenericRepository<Products>, IGenericValidation<Products>
    {
    }
}
