using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakip.Models
{
    [Table("Users")]
    public class AppUser: BaseModel
    {
        public string Password { get; set; }
    }
}
