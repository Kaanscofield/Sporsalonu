using System.ComponentModel.DataAnnotations;

namespace Sporsalonu.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string sifre { get; set; }

    }
}