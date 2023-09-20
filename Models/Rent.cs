using LibrarieStore.Data;

namespace LibrarieStore.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
        public string? DatetimeRent { get; set; }
        public string? Datetimeback { get; set; }
        public bool Return { get; set; }

    }
}