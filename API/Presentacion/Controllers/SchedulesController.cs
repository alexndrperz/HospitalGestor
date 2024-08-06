using Microsoft.AspNetCore.Mvc;
using Negocio.Contracts;
using Negocio.DataFormatters;
using Negocio.DTOs;
using Negocio.Mockups;

namespace Presentacion.Controllers
{
    [Route("api/schedules")]
    public class SchedulesController : Controller
    {
        private readonly IScheduleService _scheduleService;
        public SchedulesController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpGet]
        public async Task<IActionResult> getAllSchedInputAsync()
        {
            MsgServer result = await _scheduleService.getAllInputScheds();
            if (!result.success) return StatusCode(result.status, result.data);
            return Ok(result.data);
        }

        [HttpGet("{day}/{doctor_id}")]
        public async Task<IActionResult> getAllSchedInputAsync(int day, int doctor_id)
        {
            MsgServer result = await _scheduleService.retrieveSchedsPerDayEtDoctor(day, doctor_id);
            if (!result.success) return StatusCode(result.status, result.data);
            return Ok(result.data);
        }

        [HttpPost]
        public async Task<IActionResult> createSchedRegister([FromBody] List<SchedulesRegisterCreateDTO> sched)
        {
            MsgServer result = await _scheduleService.createSchedRegister(sched);
            if (!result.success) return StatusCode(result.status, result.data);
            return Ok(result.data);
        }
    }
}
