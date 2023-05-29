﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace QUANLYTHUVIEN.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230528165324_Create_table_Book")]
    partial class Create_table_Book
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("QUANLYTHUVIEN.Models.Author", b =>
                {
                    b.Property<string>("AuthorID")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorID");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("QUANLYTHUVIEN.Models.Book", b =>
                {
                    b.Property<string>("BookID")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NXBID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NamXuatBan")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("NXBID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("QUANLYTHUVIEN.Models.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("QUANLYTHUVIEN.Models.Nhaxuatban", b =>
                {
                    b.Property<string>("NXBID")
                        .HasColumnType("TEXT");

                    b.Property<string>("NXBAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NXBName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Phone")
                        .HasColumnType("INTEGER");

                    b.HasKey("NXBID");

                    b.ToTable("Nhaxuatban");
                });

            modelBuilder.Entity("QUANLYTHUVIEN.Models.Book", b =>
                {
                    b.HasOne("QUANLYTHUVIEN.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QUANLYTHUVIEN.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QUANLYTHUVIEN.Models.Nhaxuatban", "Nhaxuatban")
                        .WithMany()
                        .HasForeignKey("NXBID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Nhaxuatban");
                });
#pragma warning restore 612, 618
        }
    }
}
