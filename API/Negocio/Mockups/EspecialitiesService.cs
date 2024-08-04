using AutoMapper;
using Datos.DbContexts;
using Datos.Entities;
using Microsoft.EntityFrameworkCore;
using Negocio.Contracts;
using Negocio.DataFormatters;
using Negocio.DTOs;

namespace Negocio.Mockups
{
    public class EspecialitiesService : IEspecialitiesService
    {
        private readonly HospitalBDContext _dbContext;
        private readonly IMapper _mapper;
        public EspecialitiesService(HospitalBDContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<MsgServer> createEspecialitie(EspecialitiesCreateDTO especiality)
        {
            Especialities entity = _mapper.Map<Especialities>(especiality);
            await _dbContext.Especialities.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return MsgServer.msgSuccess(new { especiality_id = entity.id });
;        }

        public async Task<MsgServer> deshabilitateEspecialitie(int id)
        {
            var entity = await _dbContext.Especialities.FirstOrDefaultAsync(es => es.id == id && es.active);
            if (entity == null) return MsgServer.msgError(404, "No existe");
            entity.active = false;
            await _dbContext.SaveChangesAsync();
            return MsgServer.msgSuccess(null, 204);
        }

        public async Task<MsgServer> getAllEspecialities()
        {
            List<Especialities> especialities = await _dbContext.Especialities.Where(es => es.active).ToListAsync();
            return MsgServer.msgSuccess(_mapper.Map<List<EspecialitiesRetrieveDTO>>(especialities));
        }

        public async Task<MsgServer> updateEspecialitie(EspecialitiesCreateDTO especiality, int id)
        {
            var entity = await _dbContext.Especialities.FirstOrDefaultAsync(es => es.id == id && es.active);
            if (entity == null) return MsgServer.msgError(404, "No existe");
            _mapper.Map(especiality, entity);
            await _dbContext.SaveChangesAsync();
            return MsgServer.msgSuccess(null, 204);
        }
    }
}
