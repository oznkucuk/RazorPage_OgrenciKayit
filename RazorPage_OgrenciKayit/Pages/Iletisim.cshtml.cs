using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage_OgrenciKayit.Data;

namespace RazorPage_OgrenciKayit.Pages
{
    public class IletisimModel : PageModel
    {
        private readonly OgrencilerDbContext _db;

        public Iletisim Iletisim { get; set; }

        public IletisimModel(OgrencilerDbContext db)
        {
            _db = db;
        }


        public void OnGet()
        {
        }
    }
}
