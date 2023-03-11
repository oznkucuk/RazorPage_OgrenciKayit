﻿using Microsoft.EntityFrameworkCore;
using RazorPage_OgrenciKayit.Model;

namespace RazorPage_OgrenciKayit.Data
{
    public class OgrencilerDbContext : DbContext
    {
        public OgrencilerDbContext(DbContextOptions<OgrencilerDbContext> options ) : base(options)
        {
            
        }
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Kurs> Kurs { get; set; }
    }
}