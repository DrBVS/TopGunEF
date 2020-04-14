namespace EntityFrameworkExample.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string Vendor { get; set; }

        public int? StoreId { get; set; }
        public Store Store { get; set; }
    }

}
