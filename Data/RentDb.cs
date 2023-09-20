using LibrarieStore.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarieStore.Data
{
    class RentDb : DbContext
    {
        public RentDb(DbContextOptions<RentDb> options) : base(options) { }
        public DbSet<Rent> AllRent => Set<Rent> ();
    }
}