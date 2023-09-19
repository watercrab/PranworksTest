using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    class UserDb : DbContext
    {
        // public UserDb(DbContextOptions<UserDb> UserOptions) : base(UserOptions) { }
         public UserDb(DbContextOptions<UserDb> options) : base(options) { }
        // public UserDb(DbContextOptions UserOptions) : base(UserOptions) { }
        
        // public DbSet<User> Users { get; set; } = null!;
        public DbSet<User> Userss => Set<User> ();

        // public object Data { get; internal set; }
    }
}