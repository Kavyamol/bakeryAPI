﻿using System;
using System.Collections.Generic;
using System.Text;
using BakedInHeaven.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BakedInHeaven.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Products> Products { get; set; }

        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=bakerydb1;Username=postgres;Password=kavyamol");
    }
}
