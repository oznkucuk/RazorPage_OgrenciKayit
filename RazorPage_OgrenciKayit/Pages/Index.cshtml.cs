using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage_OgrenciKayit.Data;
using RazorPage_OgrenciKayit.Model;

namespace RazorPage_OgrenciKayit.Pages
{
    public class IndexModel : PageModel
    {
        public class OgrenciModel : PageModel
        {
            public List<Ogrenci> Ogrencis { get; set; }

            private readonly OgrencilerDbContext _db;

            public OgrenciModel(OgrencilerDbContext db)
            {
                _db = db;
            }

            public void OnGet()
            {
                Ogrencis = _db.Ogrencis.OrderBy(c => c.Id).ToList();
            }

        }
    }
}