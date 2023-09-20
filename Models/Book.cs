using LibrarieStore.Data;

namespace LibrarieStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int CategorieId { get; set; }
        public Categorie? Categorie { get; set; }

        public int Code { get; set; }
        public string? Publisher { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }

        public ICollection<Rent>? Rents { get; set; }

    }
}