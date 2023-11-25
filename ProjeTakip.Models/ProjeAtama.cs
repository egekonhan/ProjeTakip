using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakip.Models
{
    [Table("ProjeAtamas")]
    public class ProjeAtama : BaseModel
    {
        // İlişki: Bir kullanıcı bir projeye atanabilir.
        public int PersonelId { get; set; }
        public Personel personel { get; set; }

        // İlişki: Bir proje bir kullanıcıya atanabilir.
        public int ProjeId { get; set; }
        public Proje Proje { get; set; }
    }
}
