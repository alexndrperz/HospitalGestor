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
    public class DoctorClientProfile :Profile
    {
        public DoctorClientProfile()
        {
            CreateMap<DoctorCreateDTO, Doctors>();
        }
    }
}
