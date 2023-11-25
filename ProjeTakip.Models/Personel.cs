using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakip.Models
{
    [Table("Personels")]
    public class Personel : BaseModel
    {
        public string Email { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Pozisyon { get; set; }
        public string Departman { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string MedeniHal { get; set; }

        // İlişki: Bir kullanıcı bir veya daha fazla projeye atanabilir.
        public ICollection<ProjeAtama> AtanilanProjeler { get; set; }
    }
}
