using LibrarieStore.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarieStore.Data
{
    class InfoDb : DbContext
    {
        public InfoDb(DbContextOptions<InfoDb> options) : base(options) { }
        public DbSet<Info> AllInfo => Set<Info> ();
    }
}