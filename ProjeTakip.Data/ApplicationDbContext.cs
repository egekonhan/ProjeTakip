using Microsoft.EntityFrameworkCore;
using ProjeTakip.Models;

namespace ProjeTakip.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public virtual DbSet<AppUser> Users { get; set; }
        public virtual DbSet<Gorev> Gorevs { get; set; }
        public virtual DbSet<GorevDurumu> GorevDurumus { get; set; }
        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<Proje> Projes { get; set; }
        public virtual DbSet<ProjeAtama> Projeatamas { get; set; }
        
    }
}
