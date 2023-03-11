﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPage_OgrenciKayit.Data;

#nullable disable

namespace RazorPage_OgrenciKayit.Migrations
{
    [DbContext(typeof(OgrencilerDbContext))]
    partial class OgrencilerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RazorPage_OgrenciKayit.Model.Kurs", b =>
                {
                    b.Property<int>("KursId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KursId"), 1L, 1);

                    b.Property<string>("Kursadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KursId");

                    b.ToTable("Kurs");
                });

            modelBuilder.Entity("RazorPage_OgrenciKayit.Model.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KursId")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KursId");

                    b.ToTable("Ogrencis");
                });

            modelBuilder.Entity("RazorPage_OgrenciKayit.Model.Ogrenci", b =>
                {
                    b.HasOne("RazorPage_OgrenciKayit.Model.Kurs", "Kurs")
                        .WithMany("Ogrencis")
                        .HasForeignKey("KursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kurs");
                });

            modelBuilder.Entity("RazorPage_OgrenciKayit.Model.Kurs", b =>
                {
                    b.Navigation("Ogrencis");
                });
#pragma warning restore 612, 618
        }
    }
}