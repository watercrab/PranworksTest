using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    class InfoDb : DbContext
    {
        // public InfoDb(DbContextOptions<InfoDb> InfoOptions) : base(InfoOptions) { }
        public InfoDb(DbContextOptions<InfoDb> options) : base(options) { }
        //public InfoDb(DbContextOptions InfoOptions) : base(InfoOptions) { }
        //public DbSet<Info> Infos { get; set; } = null!;
        public DbSet<Info> Infoss => Set<Info> ();
    }
}