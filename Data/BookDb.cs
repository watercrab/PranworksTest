using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    class BookDb : DbContext
    {
        // public BookDb(DbContextOptions<BookDb> bookOptions) : base(bookOptions) { }
        public BookDb(DbContextOptions<BookDb> options) : base(options) { }
        //public BookDb(DbContext DbContext) : base(DbContext) { }
        // public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Book> Bookss => Set<Book> ();
        // public DbSet<Book> Books { get; set; }
        // public DbSet<Book> Books
        // {
        //     get { return Set<Book>(); }
        // }
    }
    //public BookDb(TMDDbContext DbContext) : base(DbContext) { }
    //public CAPAlertRepository(TMDDbContext DbContext) : base(DbContext) { }
    //public CAPAreaRepository(TMDDbContext DbContext) : base(DbContext) { }
    //public EarthquakeWorldwideRepository(TMDDbContext DbContext) : base(DbContext) { }
}
