using Datos.DTOs;
using Microsoft.AspNetCore.Mvc;
using Negocio.Contracts;
using Negocio.DataFormatters;
using Negocio.DTOs;
using Negocio.Mockups;

namespace Presentacion.Controllers
{
    [Route("/user-dep")]
    public class DoctorClientController : Controller
    {
        private readonly IDoctorClientService _doctorClientService;
        public DoctorClientController(IDoctorClientService doctorClientService)
        {
            _doctorClientService = doctorClientService;
        }

        [HttpGet("/doctors")]
        public async Task<IActionResult> getAllDoctors()
        {
   
            MsgServer result = await _doctorClientService.getAllDoctors();
            if (!result.success) return StatusCode(result.status, result.data);
            return Ok(result.data);
        }

        [HttpPut("/doctors/{doctor_id}")]
        public async Task<IActionResult> updateDoctorInfo( int doctor_id, DoctorCreateDTO doctor)
        {

            MsgServer result = await _doctorClientService.updateDoctorInfo(doctor_id, doctor);
            if (!result.success) return StatusCode(result.status, result.data);
            return Ok(result.data);
        }

        [HttpPut("/client/{client_id}")]
        public async Task<IActionResult> updateClientInfo(int client_id, ClientCreateDTO client)
        {

            MsgServer result = await _doctorClientService.updateClientInfo(client_id, client);
            if (!result.success) return StatusCode(result.status, result.data);
            return Ok(result.data);
        }
    }
}
