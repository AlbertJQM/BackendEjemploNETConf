using DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace EjemploNETConf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly CursoService _cursoService;
        public CursoController(CursoService cursoService)
        {
            _cursoService = cursoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Curso>>> GetAll()
        {
            return Ok(await _cursoService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Curso>> GetById(int id)
        {
            return Ok(await _cursoService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Curso curso)
        {
            return Ok(await _cursoService.Create(curso));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Curso curso)
        {
            return Ok(await _cursoService.Update(curso));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _cursoService.Delete(id));
        }
    }
}
