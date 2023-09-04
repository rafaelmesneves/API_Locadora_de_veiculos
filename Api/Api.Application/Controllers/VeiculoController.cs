using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly ICadastroVeiculoService _cadastroVeiculoService;

        public VeiculoController(ICadastroVeiculoService cadastroVeiculoService)
        {
            _cadastroVeiculoService = cadastroVeiculoService;
        }

        [HttpGet("{id}", Name = "GetVeiculo")]
        public async Task<ActionResult> Get(Guid id)
        {
            try
            {
                var veiculo = await _cadastroVeiculoService.Get(id);
                if (veiculo == null)
                {
                    return NotFound();
                }
                return Ok(veiculo);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CadastroVeiculoEntity veiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _cadastroVeiculoService.Post(veiculo);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetVeiculo", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] CadastroVeiculoEntity veiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _cadastroVeiculoService.Put(veiculo);
                if (result == null)
                {
                    return BadRequest();
                }

                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _cadastroVeiculoService.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
