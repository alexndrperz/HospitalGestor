using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Validators
{
    public class RoleSecurer : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            ErrorMessage = "No puede poner role de id admin";
            return (int)value != 1;
        }
    }
}
