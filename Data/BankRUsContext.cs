using Datalagring_BankRUs_EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Datalagring_BankRUs_EFCore.Data
{
    class BankRUsContext : DbContext
    {
        // För att Entity FrameWork medveten om vår Customer-Modell
        // då behöver vi implimentera DbSet<>
        public DbSet<Customer> Customer { get; set; }
        public ILoggerFactory Factory { get; }

        public BankRUsContext(ILoggerFactory factory)
        {
            Factory = factory;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(Factory);

            optionsBuilder.UseSqlServer("Server=.;Initial Catalog=BankRUs;Integrated Security=true; Encrypt=True;Trust Server Certificate=True");

        }
    }
       
}

