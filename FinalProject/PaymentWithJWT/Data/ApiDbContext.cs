
using Microsoft.EntityFrameworkCore;
using PaymentWithJWT.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace PaymentWithJWT.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
        public DbSet<ItemData> Items { get; set; }



    }

}