using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class Users
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime creadoEn { get; set; } = DateTime.Now;
        [ForeignKey("role_id")]
        public Roles role { get; set; }
        public int role_id { get; set; }

    }
}
