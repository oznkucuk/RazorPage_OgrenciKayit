using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RazorPage_OgrenciKayit.Model
{
    public class Iletisim
    {
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Aciklama { get; set; }
        public int MesajId { get; set; }

        public ICollection<Iletisim> Iletisims { get; set; }

      
    }
}
