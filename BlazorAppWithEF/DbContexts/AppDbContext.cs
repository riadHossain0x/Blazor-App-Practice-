﻿using BlazorAppWithEF.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppWithEF.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; } = null!;
    }
}
