using System.ComponentModel.DataAnnotations;
using System.Windows.Input;

namespace Sporsalonu.Models.Siniflar
{
    public class Layout
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }  
        public string Password { get; set; } 
    }
}