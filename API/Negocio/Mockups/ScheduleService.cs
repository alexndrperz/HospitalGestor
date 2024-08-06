using AutoMapper;
using Datos.DbContexts;
using Datos.Entities;
using Microsoft.EntityFrameworkCore;
using Negocio.Contracts;
using Negocio.DataFormatters;
using Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mockups
{
    public class ScheduleService : IScheduleService
    {

        private readonly HospitalBDContext _dbContext;
        private readonly IMapper _mapper;

        public ScheduleService(HospitalBDContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper =mapper;
        }

        public async Task<MsgServer> createSchedRegister(List<SchedulesRegisterCreateDTO> schedule)
        {
            var entity = _mapper.Map<List<SchedulesRegister>>(schedule);
            await _dbContext.SchedulesRegisters.AddRangeAsync(entity);
            await _dbContext.SaveChangesAsync();
            return MsgServer.msgSuccess(new { msg = "Creado con exito" });
        }

        public async Task<MsgServer> retrieveSchedsPerDayEtDoctor(int day, int doctor_id)
        {
            List<SchedulesRegister> schedulesRegisters = await _dbContext.SchedulesRegisters
                .Include(sc => sc.day)
                .Include(sc => sc.sched)
                .Where(sc =>  sc.day_id == day && sc.doctor_id == doctor_id)
                .ToListAsync();
            return MsgServer.msgSuccess(_mapper.Map<List<ScheduleRegisterRetrieveDTO>>(schedulesRegisters));
        }

        public async Task<MsgServer> getAllInputScheds()
        {
            var entities = await _dbContext.SchedulesSystems.ToListAsync();
            return MsgServer.msgSuccess(entities);
        }
    }
}
