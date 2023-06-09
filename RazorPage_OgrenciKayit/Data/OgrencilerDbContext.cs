﻿using Microsoft.EntityFrameworkCore;
using RazorPage_OgrenciKayit.Model;
using RazorPage_OgrenciKayit.Pages;

namespace RazorPage_OgrenciKayit.Data
{
    public class OgrencilerDbContext : DbContext
    {
        public OgrencilerDbContext(DbContextOptions<OgrencilerDbContext> options) : base(options)
        {

        }
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Kurs> Kurs { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Iletisim>().HasKey(i => i.MesajId);
        }
    }
}
