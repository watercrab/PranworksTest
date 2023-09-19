using Library.Data;

namespace Library.Models
{
    public class Info
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public string? Date { get; set; }
        public string? TimeIn { get; set; }
        public string? TimeOut { get; set; }

        //   public ICollection<User> Users { get; }
        // public ICollection<User>? Users { get; set;} 
        // can use

        // public int UserId { get; set; }
        // public User? User { get; set; }
    }
}