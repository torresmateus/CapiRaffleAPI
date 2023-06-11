using CapiRaffle.BLL;
using CapiRaffle.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapiRaffle.BLLService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompradorController : ControllerBase
    {
        [HttpGet(Name = "GetComprador")]
        public ActionResult<List<Comprador>> GetComprador()
        {
            try
            {
                List<Comprador> list = CompradorRepository.GetAll();
                if (list != null)
                {
                    return Ok(list);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}", Name = "GetCompradorById")]
        public ActionResult<Comprador> GetCompradorById(int id)
        {
            Comprador _comprador = CompradorRepository.GetById(id);

            try
            {
                if (_comprador != null)
                {
                    return Ok(_comprador);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "AddComprador")]
        public ActionResult<Comprador> AddComprador(Comprador comprador)
        {
            try
            {
                CompradorRepository.Add(comprador);
                return CreatedAtAction(nameof(GetCompradorById),
                    new { id = comprador.Id },
                    comprador);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteComprador")]
        public ActionResult DeleteComprador(int id)
        {
            try
            {
                var comprador = CompradorRepository.GetById(id);
                CompradorRepository.Excluir(comprador);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("findByName/{name}", Name = "GetCompradorByName")]
        public ActionResult<Comprador> GetCompradorByName(string name)
        {
            Comprador _comprador = CompradorRepository.GetByName(name);

            try
            {
                if (_comprador != null)
                {
                    return Ok(_comprador);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }


}
