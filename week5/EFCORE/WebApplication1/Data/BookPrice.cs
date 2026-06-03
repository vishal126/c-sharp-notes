namespace WebApplication1.Data
{
    public class BookPrice
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Decimal Amount { get; set; }
        public int CurrencyId { get; set; }


        //public Book Book { get; set; }
        //public Currency Currency { get; set; }

        // for lazy loading
        public virtual Book Book { get; set; }
        public virtual Currency Currency { get; set; }
    }
}
