using Microsoft.EntityFrameworkCore;
using SignalR.Api.Entities;

namespace SignalR.Api.Context
{
    public class CustomerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DD\\SQLEXPRESS02;database=SignalRDb;integrated security=true;TrustServerCertificate=True;");


        }
        public DbSet<Customer> Customers { get; set; }
    }
}
