using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage_OgrenciKayit.Data;
using RazorPage_OgrenciKayit.Model;

namespace RazorPage_OgrenciKayit.Pages
{
    public class KursEklemeModel : PageModel
    {
        private readonly OgrencilerDbContext _db;

        [BindProperty]
        public Kurs Kurs { get; set; }

        public KursEklemeModel(OgrencilerDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }
        public ActionResult OnPost()
        {

                _db.Kurs.Add(Kurs);
                _db.SaveChanges();
                return RedirectToPage("Kurslar");
        }
    }
}
