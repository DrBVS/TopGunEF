using System;
using System.Data.Entity;
using System.Linq;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PhoneContext())
            {
                //context.Stores.Add(new Store
                //{
                //    Name = "Citrus"
                //});

                //context.SaveChanges();

                //context.Phones.Add(new Phone
                //{
                //    Model = "Galaxy S10",
                //    Price = 20
                //});

                //context.Smartphones.Add(new Smartphone
                //{
                //    Model = "Pixel 4",
                //    OS = "Android",
                //    Vendor = "Google",
                //    Price = 40
                //});

                //context.SaveChanges();

                var smartphones = context.Smartphones.Include(s => s.Store).ToList();
                foreach (var phone in smartphones)
                {
                    Console.WriteLine($"{phone.Vendor} {phone.Model} - {phone.Price}$ in {phone.Store.Name}");
                }
            }
        }
    }
}
