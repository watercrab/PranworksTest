namespace Library.Models 
{
    public class Categorie
    {
          public int Id { get; set; }
          public string? Code { get; set; }
          public string? Name { get; set; }

        //   public int BookId { get; set; } can use
        //   public Book? Book { get; set; }

          public ICollection<Book>? Books { get; set;}
    }
}