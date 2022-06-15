using Amrproject.Models;

namespace Amrproject.IRepo
{
    public interface IUser :IGenericRepository<User>
    {

        bool IsPasswordMatch(string Password, string ConfirmPassword);
        User LogIn(string UserName, string Password);
        bool IsUserValidate(User entity, bool IsUpdate = false);
        bool IsUserNameExist(string UserName);
        bool IsExist(int Id);
        bool IsExist(string UserName, string Password);
    }
}
