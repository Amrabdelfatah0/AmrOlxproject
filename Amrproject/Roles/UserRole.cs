using Amrproject.Bases;
using Amrproject.Models;

namespace Amrproject.Roles
{
    public class UserRole :Base
    {
        public string Name { get; set; }
        public List<User> users { get; set; }
    }
}
