using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UserManagement.Models;

namespace UserManagement.Data;

public partial class ContosoPizza2Context : DbContext
{
    public ContosoPizza2Context()
    {
    }

    public ContosoPizza2Context(DbContextOptions<ContosoPizza2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ContosoPizza2;Integrated Security=True;TrustServerCertificate=True;TrustServerCertificate=True;");*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasOne(d => d.User).WithMany(p => p.Posts).HasConstraintName("FK_Post_User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
