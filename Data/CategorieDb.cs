using LibrarieStore.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarieStore.Data
{
    class CategorieDb : DbContext
    {
        public CategorieDb(DbContextOptions<CategorieDb> options) : base(options) { }
        public DbSet<Categorie> AllCategorie => Set<Categorie> ();
    }
}