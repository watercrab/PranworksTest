namespace LibrarieStore.Models 
{
    public class Categorie
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}