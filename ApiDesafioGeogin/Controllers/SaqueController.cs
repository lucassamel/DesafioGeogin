using Domain.Business;
using Domain.Model;
using Domain.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDesafioGeogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaqueController : ControllerBase
    {
        private readonly CaixaEletronicoRepository _caixaEletronicoRepository;
        private readonly CaixaEletronicoBusiness _caixaEletronicoBusiness;

        public SaqueController()
        {
            _caixaEletronicoRepository = new CaixaEletronicoRepository();
            _caixaEletronicoBusiness = new CaixaEletronicoBusiness();
        }
        /// <summary>
        /// Obtem as notas e o valor total disponível no caixa.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<CaixaEletronico> Get()
        {         
            return Ok(_caixaEletronicoRepository.ObterNotasDisponiveis());
        }     
        /// <summary>
        /// Realiza o saque e atualiza a disponibilidade de notas no caixa.
        /// </summary>
        /// <param name="valorSaque"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] int valorSaque)
        {
            try
            {
                CaixaEletronico cx = _caixaEletronicoBusiness.RealizarSaque(valorSaque);

                return Ok(cx);
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
                  
            
        }    
       
    }
}
