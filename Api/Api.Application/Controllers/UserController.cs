using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities; // Certifique-se de que as entidades corretas estejam importadas
using Api.Domain.Interfaces.Services.Cadastro; // Importe as interfaces corretas
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ICadastroService _cadastroService;

        public UsersController(ICadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpGet("{id}", Name = "GetWithId")]
        public async Task<ActionResult> Get(Guid id)
        {
            try
            {
                var cadastro = await _cadastroService.Get(id);
                if (cadastro == null)
                {
                    return NotFound();
                }
                return Ok(cadastro);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var cadastros = await _cadastroService.GetAll();
                return Ok(cadastros);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CadastroEntity cadastro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var createdCadastro = await _cadastroService.Post(cadastro);
                return CreatedAtRoute("GetWithId", new { id = createdCadastro.Id }, createdCadastro);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] CadastroEntity cadastro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var updatedCadastro = await _cadastroService.Put(cadastro);
                if (updatedCadastro == null)
                {
                    return NotFound();
                }
                return Ok(updatedCadastro);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                var deleted = await _cadastroService.Delete(id);
                if (!deleted)
                {
                    return NotFound();
                }
                return NoContent();
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
