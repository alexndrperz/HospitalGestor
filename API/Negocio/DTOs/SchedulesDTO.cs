using Datos.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DTOs
{
    public class SchedulesRegisterCreateDTO
    {
        public int day_id { get; set; }
        public int doctor_id { get; set; }

        public int sched_id { get; set; }

    }

    public class ScheduleRegisterRetrieveDTO
    {
        public int id { get; set; } 
        public SchedSystemRetrieveDTO sched { get; set; }
        public Days day { get; set; }
    }

    public class SchedSystemRetrieveDTO
    {
        public int id { get; set; }
        public DateTime initHour { get; set; }  
        public DateTime finalHour { get; set; } 
    }
}
