using ProjeTakip.Data;
using ProjeTakip.Models;
using ProjeTakip.Repository.Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakip.Repository.Shared.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IRepository<AppUser> Users { get; private set; }
        public IRepository<Gorev> Gorevs { get; private set; }

        public IRepository<GorevDurumu> GorevDurumus { get; private set; }

        public IRepository<Personel> Personels { get; private set; }

        public IRepository<Proje> Projes { get; private set; }

        public IRepository<ProjeAtama> ProjeAtamas { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Users = new Repository<AppUser>(_context);
            Gorevs = new Repository<Gorev>(_context);
            GorevDurumus = new Repository<GorevDurumu>(_context);
            Personels = new Repository<Personel>(_context);
            Projes = new Repository<Proje>(_context);
            ProjeAtamas = new Repository<ProjeAtama>(_context);

        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
