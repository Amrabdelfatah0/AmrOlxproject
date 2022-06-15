using Amrproject.Models;
using Amrproject.Models.Communication;
using Amrproject.Models.Location;
using Amrproject.Roles;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Amrproject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Governrote> governrotes { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Mobile> mobiles { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
        public DbSet<User> User { get; set; }
    }
}