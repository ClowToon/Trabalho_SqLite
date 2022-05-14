using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YorgutCadastro.Application.Dto;
using YorgutCadastro.Application.Interfaces;
using YorgutCadastro.Dto;

namespace YorgutCadastro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class YorgutCadastroController : ControllerBase
    {
        private readonly IYorgutService _yorgutService;

        public YorgutCadastroController(IYorgutService yorgutService)
        {
            _yorgutService = yorgutService;
        }

        [HttpPost("PostCadastro")]
        public IActionResult PostCadastro([FromBody] CadastroDto inputDados)
        {

            _yorgutService.Add(inputDados);

            return Ok();
        }

        [HttpPost("PostLogar")]
        public async Task<IActionResult> PostLogar(EntradaLoginDto entradaLoginDto)
        {
            var result = await _yorgutService.Login(entradaLoginDto.Username, entradaLoginDto.Password);

            if (result.Status == 404) return NotFound(result.Mensagem);

            if (result.Status == 400) return NotFound(result.Mensagem);

            return Ok(result.Item);
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            var result = await _yorgutService.Get();

            return Ok(result.Item);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete()
        {
             _yorgutService.Delete();

            return Ok();
        }
    }
}
