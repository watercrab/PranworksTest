namespace Library.Models
{
    public class User
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Tel { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public char Status { get; set; }

        //   public int UserId { get; set; }
          //   public int InfoId { get; set; } can use
        //   public Info? Info { get; set; }
        //   public int RentId { get; set; } can use
        //   public Rent? Rent { get; set; }
        public ICollection<Info>? Infos { get; set; }
        public ICollection<Rent>? Rents { get; set;}
    }
}