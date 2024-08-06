using Datos.Entities;
using Negocio.DataFormatters;
using Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contracts
{
    public interface IScheduleService
    {
        public Task<MsgServer> getAllInputScheds();
        Task<MsgServer> createSchedRegister(List<SchedulesRegisterCreateDTO> schedule);
        Task<MsgServer> retrieveSchedsPerDayEtDoctor(int day, int doctor_id);
    }
}
