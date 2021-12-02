using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PaymentAPIWithJWT3.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace PaymentAPIWithJWT3.Data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<ItemData> Items { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

    }

}