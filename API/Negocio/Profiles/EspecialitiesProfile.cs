using AutoMapper;
using Datos.Entities;
using Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Profiles
{
    internal class EspecialitiesProfile : Profile
    {
        public EspecialitiesProfile()
        {
            CreateMap<EspecialitiesCreateDTO, Especialities>();
            CreateMap<Especialities, EspecialitiesRetrieveDTO>();
        }
    }
}
