using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entities
{
    public class SchedulesSystem
    {
        public int Id { get; set; }
        public DateTime initHour { get; set; }
        public DateTime finalHour { get; set; }

    }
}
