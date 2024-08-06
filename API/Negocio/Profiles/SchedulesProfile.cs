using AutoMapper;
using Datos.Entities;
using Datos.Migrations;
using Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Profiles
{
    public class SchedulesProfile :Profile
    {
        public SchedulesProfile()
        {
            CreateMap<SchedulesRegisterCreateDTO, SchedulesRegister>();
            CreateMap<SchedulesRegister, ScheduleRegisterRetrieveDTO>();
            CreateMap<SchedulesSystem, SchedSystemRetrieveDTO>();
        }
    }
}
