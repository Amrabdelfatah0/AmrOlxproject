namespace Amrproject.IRepo
{
    public interface IGenericRepository <T> where T : class
    {
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task Delete(T entity);
        Task<T> Get(int id);
        List<T> Get(); 


    }
}
