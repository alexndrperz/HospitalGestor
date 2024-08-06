using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class SchedulesRegister
    {
        public int id { get; set; }

        [ForeignKey("day_id")]
        public Days day { get; set; }
        public int day_id { get; set; }
        [ForeignKey("doctor_id")]
        public Doctors doctor { get; set; }
        public int doctor_id { get; set; }
        [ForeignKey("sched_id")]
        public SchedulesSystem sched { get; set; }
        public int sched_id { get; set; }


    }
}
