using Datos.Entities;
using Microsoft.AspNetCore.Mvc;
using Negocio.Contracts;
using Negocio.DataFormatters;
using Negocio.DTOs;
using Negocio.Mockups;

namespace Presentacion.Controllers
{
    [Route("api/especialities")]
    public class EspecialitiesController : Controller
    {
        private readonly IEspecialitiesService _especialitiesService; 
        public EspecialitiesController(IEspecialitiesService especialitiesService)
        {
            _especialitiesService = especialitiesService;   
        }

        [HttpGet]   
        public async Task<IActionResult> getAllAsync()
        {
            MsgServer result = await _especialitiesService.getAllEspecialities();
            if (!result.success) return StatusCode(result.status, result.data);
            return Ok(result.data);

        }

        [HttpPost]
        public async Task<IActionResult> getAllAsync([FromBody] EspecialitiesCreateDTO especiality)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            MsgServer result = await _especialitiesService.createEspecialitie(especiality);
            if (!result.success) return StatusCode(result.status, result.data);
            return Ok(result.data);

        }

        [HttpPut("{especialite_id}")]
        public async Task<IActionResult> updateEspecAsync(int especialite_id, [FromBody] EspecialitiesCreateDTO especialitie)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            MsgServer result = await _especialitiesService.updateEspecialitie(especialitie, especialite_id);
            if (!result.success) return StatusCode(result.status, result.data);
            return Ok(result.data);

        }

        [HttpDelete("{especialite_id}")]
        public async Task<IActionResult> getAllAsync(int especialite_id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            MsgServer result = await _especialitiesService.deshabilitateEspecialitie(especialite_id);
            if (!result.success) return StatusCode(result.status, result.data);
            return Ok(result.data);

        }
    }
}
