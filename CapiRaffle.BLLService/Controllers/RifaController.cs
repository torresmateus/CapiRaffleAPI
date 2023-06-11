using CapiRaffle.BLL;
using CapiRaffle.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapiRaffle.BLLService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RifaController : ControllerBase
    {
        [HttpGet(Name = "GetRifa")]
        public ActionResult<List<Rifa>> GetRifa()
        {
            try
            {
                List<Rifa> list = RifaRepository.GetAll();
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

        [HttpGet("{id}", Name = "GetRifaById")]
        public ActionResult<Rifa> GetRifaById(int id)
        {
            Rifa _rifa = RifaRepository.GetById(id);

            try
            {
                if (_rifa != null)
                {
                    return Ok(_rifa);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "AddRifa")]
        public ActionResult<Rifa> AddRifa(Rifa rifa)
        {
            try
            {
                RifaRepository.Add(rifa);
                return CreatedAtAction(nameof(GetRifaById),
                    new { id = rifa.Id },
                    rifa);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        

        [HttpDelete(Name = "DeleteRifa")]
        public ActionResult DeleteRifa(int id)
        {
            try
            {
                var rifa = RifaRepository.GetById(id);
                RifaRepository.Excluir(rifa);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("findByName/{name}", Name = "GetRifaByName")]
        public ActionResult<Rifa> GetRifaByName(string name)
        {
            Rifa _rifa = RifaRepository.GetByName(name);

            try
            {
                if (_rifa != null)
                {
                    return Ok(_rifa);
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
