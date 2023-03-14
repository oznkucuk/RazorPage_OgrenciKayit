using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage_OgrenciKayit.Data;
using RazorPage_OgrenciKayit.Model;

namespace RazorPage_OgrenciKayit.Pages
{
    public class IletisimModel : PageModel
    {
        [BindProperty]
        public Iletisim Iletisim { get; set; }

        private readonly OgrencilerDbContext _db;

        public IletisimModel(OgrencilerDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }
        public ActionResult OnPost()
        {

            _db.Iletisims.Add(Iletisim);
            _db.SaveChangesAsync();
            return RedirectToPage("Iletisim");

            //return Page();
        }
    }
}
