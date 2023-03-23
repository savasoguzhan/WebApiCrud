﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiCrud22032023.Data;

#nullable disable

namespace WebApiCrud22032023.Data.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    [Migration("20230322065538_Ilk")]
    partial class Ilk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApiCrud22032023.Data.Kisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Kisiler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Ali"
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Efe"
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Can"
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Ada"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}