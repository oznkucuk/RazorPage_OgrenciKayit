﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage_OgrenciKayit.Data;
using RazorPage_OgrenciKayit.Model;

namespace RazorPage_OgrenciKayit.Pages
{
    public class OgrencilerModel : PageModel
    {
        
        public Ogrenci Ogrenci { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
        public List<Kurs> Kurslar { get; set; }

        private readonly ILogger<OgrencilerModel> _logger;
        private readonly OgrencilerDbContext _db;

        public OgrencilerModel(ILogger<OgrencilerModel> logger , OgrencilerDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            Ogrenciler = _db.Ogrencis.ToList();
            Kurslar = _db.Kurs.ToList();
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                _logger.LogInformation("GEÇERSİZ!!!! ");
                return Page();
            }

            if (Ogrenci != null)
            {
                _db.Ogrencis.Add(Ogrenci);
                _db.SaveChanges();
                return RedirectToPage("index");
            }

            return Page();
        }
    }
}