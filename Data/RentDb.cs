using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    class RentDb : DbContext
    {
        // public RentDb(DbContextOptions<RentDb> RentOptions) : base(RentOptions) { }
        public RentDb(DbContextOptions<RentDb> options) : base(options) { }
        // public RentDb(DbContextOptions RentOptions) : base(RentOptions) { }
        //public DbSet<Rent> Rents { get; set; } = null!;
        public DbSet<Rent> Rentss => Set<Rent> ();
    }
}