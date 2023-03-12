using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage_OgrenciKayit.Data;
using RazorPage_OgrenciKayit.Model;

namespace RazorPage_OgrenciKayit.Pages
{
    public class KurslarModel : PageModel
    {
        [BindProperty]
        public List<Ogrenci> Ogrenciler { get; set; }
        [BindProperty]
        public List<Kurs> Kurslar { get; set; }

        private readonly OgrencilerDbContext _db;

        public KurslarModel(OgrencilerDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Kurslar = _db.Kurs.ToList();
            Ogrenciler = _db.Ogrencis.ToList();
        }
        
    }
}
