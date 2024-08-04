using Negocio.DataFormatters;
using Negocio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contracts
{
    public interface IEspecialitiesService
    {
         Task<MsgServer> getAllEspecialities();
         Task<MsgServer> createEspecialitie(EspecialitiesCreateDTO especiality);
         Task<MsgServer> updateEspecialitie(EspecialitiesCreateDTO especiality, int id);
         Task<MsgServer> deshabilitateEspecialitie(int id);

    }
}
