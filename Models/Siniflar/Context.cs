using System.Data.Entity;

namespace Sporsalonu.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins  { get; set; }
        public DbSet<Layout> Layouts { get; set; }  
    }
}