using LibrarieStore.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarieStore.Data
{
    class UserDb : DbContext
    {
         public UserDb(DbContextOptions<UserDb> options) : base(options) { }
        public DbSet<User> AllUser => Set<User> ();
    }
}