using AutoMapper;
using Datos.DbContexts;
using Datos.DTOs;
using Datos.Entities;
using Microsoft.EntityFrameworkCore;
using Negocio.Contracts;
using Negocio.DataFormatters;
using System.Net;


namespace Negocio.Mockups
{
    public class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly HospitalBDContext _dbContext;
        public AuthService(IMapper mapper, HospitalBDContext dbContext)
        {
            _dbContext = dbContext;
            _mapper = mapper;   
        }

        public async Task<MsgServer> authUser(UsersAuthDTO usersAuthDTO)
        {
            var collectionUsers = _dbContext.Users as IQueryable<Users>;
            var user = await collectionUsers.FirstOrDefaultAsync(us => us.username == usersAuthDTO.username);
            if (user == null) return MsgServer.msgError(401, "Usuario no existe");
            if (user.password != usersAuthDTO.password) return MsgServer.msgError(401, "Contraseña incorrecta");
            int entId = 0;
            bool llenoDatos = false;
            if (user.role_id == 2)
            {
                var ent = await _dbContext.Doctors.FirstOrDefaultAsync(en => en.user_id == user.id);
                if (ent == null) return MsgServer.msgError(401, "No existe objet");
                llenoDatos = ent.dataReady;
                entId = ent.Id;
            }
            if(user.role_id == 3)
            {
                var ent = await _dbContext.Client.FirstOrDefaultAsync(en => en.user_id == user.id);
                if (ent == null) return MsgServer.msgError(401, "No existe objet");
                llenoDatos = ent.dataReady;
                entId = ent.id;
            }

            


            return MsgServer.msgSuccess(new { user_id = user.id, role_id = user.role_id, username = user.username, aditionalEnt = entId, dataReady = llenoDatos });
        }

        public async Task<MsgServer> createUser(UserCreateDTO usersAuthDTO)
        {
            Users user = _mapper.Map<Users>(usersAuthDTO);
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            if (usersAuthDTO.role_id == 2) await _dbContext.Doctors.AddAsync(new Doctors() {fullName ="", email = "", telefono="",especiality_id =1, user_id=  user.id});
            if (usersAuthDTO.role_id == 3) await _dbContext.Client.AddAsync(new Client() {name = "",phone="", user_id=  user.id});
            await _dbContext.SaveChangesAsync();
            return MsgServer.msgSuccess(new { user_id = user.id }, 201);
        }
    }
}
