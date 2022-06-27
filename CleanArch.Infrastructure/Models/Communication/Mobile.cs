using System.ComponentModel.DataAnnotations.Schema;

namespace Amrproject.Models.Communication
{
    public class Mobile
    {

        public string Number { get; set; }
        public int UserId { get; set; }
       [ForeignKey("UserId")]
        public User user { get; set; }
    }
}
