using Library.Data;

namespace Library.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
        //    can use
        public int UserId { get; set; }
        //   can use
        public User? User { get; set; }
        public int DatetimeRent { get; set; }
        public int Datetimeback { get; set; }
        public bool Return { get; set; }

        //   public ICollection<User> Users { get; }
        //   public ICollection<Book> Books { get; }

        // public ICollection<User>? Users { get; set;}
        // public ICollection<Book>? Books { get; set; }

        // public int UserId { get; set; }
        // public int BookId { get; set; }
        // public User? User { get; set; }

        // public int UserId { get; set; }
        // public Rent Rent { get; set; }

        // public int BookId { get; set; }
        // public Rent? Rent { get; set; }
    }
}