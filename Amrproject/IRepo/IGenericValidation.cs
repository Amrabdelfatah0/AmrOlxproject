namespace Amrproject.IRepo
{
    public interface IGenericValidation<T> where T : class
    {
        bool ISExist (T entity);
        bool IsValid (T entity);
    }
}
