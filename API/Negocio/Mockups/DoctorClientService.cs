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
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Mockups
{
    public class DoctorClientService : IDoctorClientService
    {
        private readonly HospitalBDContext _dbContext;
        private readonly IMapper _mapper;
        public DoctorClientService(HospitalBDContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<MsgServer> getAllDoctors()
        {
            List<Doctors> doctors = _dbContext.Doctors.ToList();
            return MsgServer.msgSuccess(doctors);
        }

        public async Task<MsgServer> updateDoctorInfo(int doctor_id, DoctorCreateDTO doctor)
        {
            var entity = await _dbContext.Doctors.FirstOrDefaultAsync(es => es.Id == doctor_id);
            if (entity == null) return MsgServer.msgError(404, "No existe");
            _mapper.Map(doctor, entity);
            await _dbContext.SaveChangesAsync();
            return MsgServer.msgSuccess(null, 204);
        } 

        public async Task<MsgServer> updateClientInfo(int client_id, ClientCreateDTO client)
        {
            var entity = await _dbContext.Client.FirstOrDefaultAsync(es => es.id == client_id);;
            if (entity == null) return MsgServer.msgError(404, "No existe");
            _mapper.Map(client, entity);
            await _dbContext.SaveChangesAsync();
            return MsgServer.msgSuccess(null, 204);
        }
    }
}
