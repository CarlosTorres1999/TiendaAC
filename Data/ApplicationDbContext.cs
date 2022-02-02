using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using StockManagerAC.Models;

namespace StockManagerAC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<StockManagerAC.Models.Producto> Producto { get; set; }
        public DbSet<StockManagerAC.Models.Venta> Venta { get; set; }
        public DbSet<StockManagerAC.Models.Moroso> Moroso { get; set; }
    }
}
