namespace LibrarieStore.Models
{
    public class User
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Tel { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public char Status { get; set; }

        public ICollection<Info>? Infos { get; set; }
        public ICollection<Rent>? Rents { get; set; }
    }
}