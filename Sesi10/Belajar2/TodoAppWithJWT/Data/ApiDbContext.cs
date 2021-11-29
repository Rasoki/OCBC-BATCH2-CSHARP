using Microsoft.EntityFrameworkCore;
using TodoAppWithJWT.Models;


namespace TodoAppWithJWT.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<ItemData> Items { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}