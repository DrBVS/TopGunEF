using EntityFrameworkExample.Models;
using System.Data.Entity;

namespace EntityFrameworkExample
{
    public class PhoneContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Smartphone> Smartphones { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
