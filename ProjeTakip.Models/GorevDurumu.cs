using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakip.Models
{
    [Table("GorevDurumus")]
    public class GorevDurumu : BaseModel
    {
        public string DurumAdi { get; set; }

        // İlişki: Bir görev durumu bir veya daha fazla göreve sahip olabilir.
        public ICollection<Gorev> Gorevler { get; set; }
    }
}
