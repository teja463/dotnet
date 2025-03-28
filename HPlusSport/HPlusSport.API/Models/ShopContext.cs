﻿using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Models;

public class ShopContext : DbContext
{

    public ShopContext(DbContextOptions<ShopContext> options): base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne(c => c.Category)
            .HasForeignKey(c => c.CategoryId);



        modelBuilder.Seed();
    }

    internal void Find(int id)
    {
        throw new NotImplementedException();
    }

    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }



}
