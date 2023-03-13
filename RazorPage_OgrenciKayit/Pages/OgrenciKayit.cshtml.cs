using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage_OgrenciKayit.Data;
using RazorPage_OgrenciKayit.Model;

namespace RazorPage_OgrenciKayit.Pages
{
    public class OgrenciKayitModel : PageModel
    {
        [BindProperty]
        public Ogrenci Ogrenci { get; set; }
        public List<Kurs> Kurslar { get; set; }

        private readonly OgrencilerDbContext _db;
        private readonly ILogger<OgrenciKayitModel> _logger;

        public OgrenciKayitModel(OgrencilerDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            Kurslar = _db.Kurs.ToList();
        }
        public ActionResult OnPost(string secId)
        {

            if (Ogrenci != null)
            {
                Ogrenci.KursId = Convert.ToInt32(secId);
                _db.Ogrencis.Add(Ogrenci);
                _db.SaveChanges();
                return RedirectToPage("Ogrenciler");
            }

            return Page();
        }
    }
}
