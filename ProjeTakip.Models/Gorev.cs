using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakip.Models
{
    [Table("Gorevs")]
    public class Gorev : BaseModel
    {
        public string GorevAdi { get; set; }
        public string Aciklama { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public bool Tamamlandi { get; set; }

        // İlişki: Bir görev bir projeye ait olabilir.
        public int ProjeId { get; set; }
        public Proje Proje { get; set; }

        // İlişki: Bir görev bir kullanıcıya atanabilir.
        public int AtananPersonelId { get; set; }
        public Personel AtananPersonel { get; set; }

        // İlişki: Bir görev bir duruma sahip olabilir.
        public int GorevDurumuId { get; set; }
        public GorevDurumu Durum { get; set; }
    }
}
