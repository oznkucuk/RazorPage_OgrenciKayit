using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage_OgrenciKayit.Pages
{
    public class OgrencilerModel : PageModel
    {
        private readonly ILogger<OgrencilerModel> _logger;

        public OgrencilerModel(ILogger<OgrencilerModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}