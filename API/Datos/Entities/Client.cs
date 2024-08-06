using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class Client
    {
        public int id { get; set; }
        public string name { get; set; }

        [ForeignKey("user_id")]
        public Users user { get; set; }
        public int user_id { get; set; }
        public string phone { get; set; }
        public bool dataReady { get; set; }
     }
}
