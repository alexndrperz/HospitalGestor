using Datos.Entities;
using Negocio.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTOs
{
    public class UsersAuthDTO
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }

    public class UserCreateDTO
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [RoleSecurer]
        public int role_id { get; set; }
    }
}
