using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;    
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DTOs
{
    public class EspecialitiesRetrieveDTO
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class EspecialitiesCreateDTO
    {
        [Required]
        public string name { get; set; }
    }
}
