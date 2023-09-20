using LibrarieStore.Data;

namespace LibrarieStore.Models
{
    public class Info
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public string? Date { get; set; }
        public string? TimeIn { get; set; }
        public string? TimeOut { get; set; }

    }
}