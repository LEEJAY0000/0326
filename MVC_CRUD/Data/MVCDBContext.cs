using Microsoft.EntityFrameworkCore;

namespace MVC_CRUD.Data
{
    public class MVCDBContext : DbContext
    {
        public MVCDBContext(DbContextOptions<MVCDBContext> options) : base(options)
        {
        }
    }
}
