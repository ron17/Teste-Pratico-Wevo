using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TestePraticoWevo.Models;
using TestePraticoWevo.Repository.Configurations;

namespace TestePraticoWevo.Controllers 
{
    [Route("api")]
    [ApiController]
    public class UsuarioController : Controller
    {
        ClienteRepository _clienteRepository = new ClienteRepository();

        [HttpGet("clientes")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 404)]
        [ProducesResponseType(typeof(string), 500)]
        public IActionResult GetAll(){
            return Ok(_clienteRepository.GetAll());
        }

        [HttpGet("cliente/{id}")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 404)]
        [ProducesResponseType(typeof(string), 500)]
        public IActionResult GetById(int id){
            return Ok(_clienteRepository.GetById(id));
        }


        [HttpPost("cliente")]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(typeof(string), 404)]
        [ProducesResponseType(typeof(string), 500)]
        public string Insert([FromBody]Cliente cliente){

            _clienteRepository.Insert(ref cliente);
            return "Cliente salvo com sucesso";
        }

        [HttpPut("cliente")]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(typeof(string), 404)]
        [ProducesResponseType(typeof(string), 500)]
        public string Update([FromBody]Cliente cliente){

            _clienteRepository.Update(cliente);
            return "Cliente alterado com sucesso";
        }

        [HttpDelete("cliente/{id}")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 404)]
        [ProducesResponseType(typeof(string), 500)]
        public IActionResult Delete(int id)
        {
            return Ok(_clienteRepository.Delete(id));
        }


    }
}