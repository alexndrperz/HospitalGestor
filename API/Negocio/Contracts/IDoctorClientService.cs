using Negocio.DataFormatters;
using Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contracts
{
    public interface IDoctorClientService
    {
        Task<MsgServer> getAllDoctors();
        Task<MsgServer> updateDoctorInfo(int doctor_id, DoctorCreateDTO doctor);
        Task<MsgServer> updateClientInfo(int client_id, ClientCreateDTO client);

    }
}
