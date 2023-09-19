using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    class CategorieDb : DbContext
    {
        //public CategorieDb(DbContextOptions options) : base(options) { }
        // public CategorieDb(DbContextOptions<CategorieDb> CategorieOptions) : base(CategorieOptions) { }
        public CategorieDb(DbContextOptions<CategorieDb> options) : base(options) { }
        // public CategorieDb(DbContextOptions CategorieOptions) : base(CategorieOptions) { }
        //public DbSet<Categorie> Categories { get; set; } = null!;
        public DbSet<Categorie> Categoriess => Set<Categorie> ();
    }
}