using Datos.DTOs;
using Negocio.DataFormatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contracts
{
    public interface IAuthService
    {
        Task<MsgServer> authUser(UsersAuthDTO usersAuthDTO); 
        Task<MsgServer> createUser(UserCreateDTO usersAuthDTO); 
        
    }
}
