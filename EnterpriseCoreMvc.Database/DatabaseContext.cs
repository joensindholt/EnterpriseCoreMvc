﻿using EnterpriseCoreMvc.Core.Products;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseCoreMvc.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}