using ProjeTakip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakip.Repository.Shared.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<AppUser> Users { get; }
        IRepository<Gorev> Gorevs { get; }
        IRepository<GorevDurumu> GorevDurumus { get;}
        IRepository<Personel> Personels { get;}
        IRepository<Proje> Projes { get;}
        IRepository<ProjeAtama> ProjeAtamas { get;}

        void Save();
    }
}
