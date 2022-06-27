using Amrproject.Models.Communication;
using Amrproject.Models.Location;
using Amrproject.Parent;
using Amrproject.Roles;
using DocumentFormat.OpenXml.Office2013.Word;
using Microsoft.VisualStudio.Services.UserAccountMapping;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amrproject.Models
{
    public class User : People
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public int UserRoleId { get; set; }
        [ForeignKey("userRole")]
        public UserRole userRole { get; set; }
        public List<Mobile> mobiles { get; set; }
        public List<Address> addresses { get; set; }

    }
}
