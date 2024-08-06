using Datos.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DTOs
{
    public class DoctorCreateDTO
    {

        public string fullName { get; set; }
        public int especiality_id { get; set; }
        public DateTime fechaInicio { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
    }


    public class ClientCreateDTO
    {
        public string name { get; set; }
        public string phone { get; set; }
    }
}
