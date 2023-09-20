using LibrarieStore.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarieStore.Data
{
    class BookDb : DbContext
    {
        public BookDb(DbContextOptions<BookDb> options) : base(options) { }
        public DbSet<Book> AllBook => Set<Book> ();
    }
}
