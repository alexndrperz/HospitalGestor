using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class Doctors
    {
        public int Id { get; set; } 
        public string fullName { get; set; }
        public DateTime fechaInicio { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public bool dataReady { get; set; } = false;
        [ForeignKey("especiality_id")]
        public Especialities Especialities { get; set; }    
        public int especiality_id { get; set; }

        [ForeignKey("user_id")]
        public Users user { get; set; }
        public int user_id { get; set; }

        public ICollection<SchedulesRegister> schedules { get; set; } 
    }
}
