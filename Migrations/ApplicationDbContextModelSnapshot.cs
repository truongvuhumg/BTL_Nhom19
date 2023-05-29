﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace QUANLYTHUVIEN.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("QUANLYTHUVIEN.Models.Chitietmuontra", b =>
                {
                    b.Property<string>("Maphieu")
                        .HasColumnType("TEXT");

                    b.Property<string>("BookID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ngaymuon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ngaytra")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Maphieu");

                    b.HasIndex("BookID");

                    b.ToTable("Chitietmuontra");
                });

            modelBuilder.Entity("QUANLYTHUVIEN.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeID")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
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

            modelBuilder.Entity("QUANLYTHUVIEN.Models.Phieumuonsach", b =>
                {
                    b.Property<string>("Maphieu")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReaderName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Maphieu");

                    b.HasIndex("EmployeeName");

                    b.HasIndex("ReaderName");

                    b.ToTable("Phieumuonsach");
                });

            modelBuilder.Entity("QUANLYTHUVIEN.Models.Readers", b =>
                {
                    b.Property<string>("ReaderID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ngaysinh")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReaderName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ReaderID");

                    b.ToTable("Readers");
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

            modelBuilder.Entity("QUANLYTHUVIEN.Models.Chitietmuontra", b =>
                {
                    b.HasOne("QUANLYTHUVIEN.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QUANLYTHUVIEN.Models.Phieumuonsach", "Phieumuonsach")
                        .WithMany()
                        .HasForeignKey("Maphieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Phieumuonsach");
                });

            modelBuilder.Entity("QUANLYTHUVIEN.Models.Phieumuonsach", b =>
                {
                    b.HasOne("QUANLYTHUVIEN.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QUANLYTHUVIEN.Models.Readers", "Readers")
                        .WithMany()
                        .HasForeignKey("ReaderName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Readers");
                });
#pragma warning restore 612, 618
        }
    }
}
