﻿// <auto-generated />
using CoreWebAppMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreWebAppMvc.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20250327045707_Serial_Number")]
    partial class Serial_Number
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoreWebAppMvc.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("SerialNumberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("CoreWebAppMvc.Models.SerialNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique()
                        .HasFilter("[ItemId] IS NOT NULL");

                    b.ToTable("SerialNumbers");
                });

            modelBuilder.Entity("CoreWebAppMvc.Models.SerialNumber", b =>
                {
                    b.HasOne("CoreWebAppMvc.Models.Item", "Item")
                        .WithOne("SerialNumber")
                        .HasForeignKey("CoreWebAppMvc.Models.SerialNumber", "ItemId");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("CoreWebAppMvc.Models.Item", b =>
                {
                    b.Navigation("SerialNumber");
                });
#pragma warning restore 612, 618
        }
    }
}
