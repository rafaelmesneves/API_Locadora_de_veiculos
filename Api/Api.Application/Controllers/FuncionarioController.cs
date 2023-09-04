
using Microsoft.AspNetCore.Mvc;
using SuaApp.Domain.Entities;
using SuaApp.Services;

namespace SuaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroFuncionarioController : ControllerBase
    {
        private readonly CadastroFuncionarioService _cadastroFuncionarioService;

        public CadastroFuncionarioController(CadastroFuncionarioService cadastroFuncionarioService)
        {
            _cadastroFuncionarioService = cadastroFuncionarioService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var funcionarios = _cadastroFuncionarioService.GetAll();
            return Ok(funcionarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var funcionario = _cadastroFuncionarioService.GetById(id);
            if (funcionario == null)
            {
                return NotFound();
            }
            return Ok(funcionario);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CadastroFuncionarioEntity funcionario)
        {
            if (funcionario == null)
            {
                return BadRequest("Dados inválidos");
            }

            if (!_cadastroFuncionarioService.IsValid(funcionario))
            {
                ModelState.AddModelError("Erro de validação", "Os dados do funcionário são inválidos.");
                return BadRequest(ModelState);
            }

            _cadastroFuncionarioService.Add(funcionario);

            return CreatedAtAction(nameof(GetById), new { id = funcionario.Id }, funcionario);
        }
    }
}
