using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakip.Models
{
    [Table("Projes")]
    public class Proje : BaseModel
    {
        public string ProjeAdi { get; set; }
        public string Aciklama { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }

        // İlişki: Bir proje bir veya daha fazla görev içerebilir.
        public ICollection<Gorev> Gorevler { get; set; }

        // İlişki: Bir proje bir veya daha fazla kullanıcıya atanabilir.
        public ICollection<ProjeAtama> AtananKullanicilar { get; set; }
    }
}
