namespace WebApplication1.Data
{
    public class Language
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        //public ICollection<Book> Books { get; set; }

        // for lazy loading
        public virtual ICollection<Book> Books { get; set; }
    }
}
