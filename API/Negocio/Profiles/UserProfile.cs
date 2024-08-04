using AutoMapper;
using Datos.DTOs;
using Datos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Profiles
{
    public  class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreateDTO, Users>(); 
        }
    }
}
