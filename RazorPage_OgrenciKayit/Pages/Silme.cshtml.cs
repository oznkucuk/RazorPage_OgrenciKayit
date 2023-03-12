using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPage_OgrenciKayit.Data;
using RazorPage_OgrenciKayit.Model;
using System.Security.Principal;

namespace RazorPage_OgrenciKayit.Pages
{
    public class SilmeModel : PageModel
    {
        [BindProperty]
        public Ogrenci Ogrenciler { get; set; }
        [BindProperty]
        public Kurs Kurs { get; set; }

        private readonly OgrencilerDbContext _db;

        public SilmeModel(OgrencilerDbContext db)
        {
            _db = db;
        }

        public ActionResult OnGet(int id)
        {


            if (id == null)
            {
                return NotFound();
            }

            Ogrenciler = _db.Ogrencis.FirstOrDefault(Ogrenciler => Ogrenciler.Id == id);

            Kurs = _db.Kurs.FirstOrDefault(k => k.KursId == Ogrenciler.KursId);

            if (Ogrenciler == null)
            {
                return NotFound();
            }
            return Page();
        }
        public ActionResult OnPost()
        {

            if (Ogrenciler != null)
            {

                _db.Ogrencis.Remove(Ogrenciler);
                _db.SaveChanges();
            }

            return RedirectToPage("Ogrenciler");
        }
    }
}
