using Microsoft.EntityFrameworkCore;
using MVC_CRUD.Models.Entities;

namespace MVC_CRUD.Data
{
    public class MVCDBContext : DbContext
    {
        public MVCDBContext(DbContextOptions<MVCDBContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers {get; set; }
    }
}
