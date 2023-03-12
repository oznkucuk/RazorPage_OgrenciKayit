using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPage_OgrenciKayit.Data;
using RazorPage_OgrenciKayit.Model;

namespace RazorPage_OgrenciKayit.Pages
{
    public class DuzenleModel : PageModel
    {
        [BindProperty]
        public Ogrenci Ogrenciler { get; set; }

        public List<Kurs> Kurslar { get; set; }

        private readonly OgrencilerDbContext _db;

        public DuzenleModel(OgrencilerDbContext db)
        {
            _db = db;
            Kurslar = _db.Kurs.ToList();
        }

        public ActionResult OnGet(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ogrenciler = _db.Ogrencis.FirstOrDefault(Ogrenciler => Ogrenciler.Id == id);

            if (Ogrenciler == null)
            {
                return NotFound();
            }
            return Page();
        }


        public ActionResult OnPost(string secId)
        {

            if (Ogrenciler != null & secId!=null)
            {
                Ogrenciler.KursId=Convert.ToInt32(secId);
                _db.Attach(Ogrenciler).State = EntityState.Modified; // bu kaydý güncelleme sýrasýnda farklý giriþler varsa bloke saðlar

                try
                {
                    _db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OgrenciExists(Ogrenciler.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            
            return RedirectToPage("Ogrenciler");
        }

        private bool OgrenciExists(int id)
        {
            return _db.Ogrencis.Any(Ogrenciler => Ogrenciler.Id == id);
        }
    }
}
