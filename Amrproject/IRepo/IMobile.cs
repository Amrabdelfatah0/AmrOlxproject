using Amrproject.Models.Communication;

namespace Amrproject.IRepo
{
    public interface IMobile : IGenericRepository<Mobile>,IGenericValidation<Mobile>
    {
        List<Mobile> GetAll(int UserId);
        bool IsExist(string Mobile);
        bool IsUserHasMobile(int UserId);
    }
}
