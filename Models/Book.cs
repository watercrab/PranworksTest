using Library.Data;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int CategorieId { get; set; } 
        public Categorie? CategorieIds { get; set; }
        // can use
        public int Code { get; set; }
        public string? Publisher { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }

        //   public ICollection<Categorie> Categories { get; }
        public ICollection<Rent>? Rents { get; set;}


        // public int RentId { get; set; } can use
        // public int CategorieId { get; set; } 
        // public Rent? Rent { get; set; }


        // public int CategorieId { get; set; }
        // public Book Book { get; set; }

        // public ICollection<Book>? Books { get; set;}
    }
}