namespace RazorPage_OgrenciKayit.Model
{
    public class Kurs
    {
        public int KursId { get; set; }
        public string Kursadi { get; set; }
        public ICollection<Ogrenci> Ogrencis { get; set; }
    }
}
