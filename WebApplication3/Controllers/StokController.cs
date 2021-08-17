using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.StokData;

namespace WebApplication3.Controllers
{

    [ApiController]
    public class StokController : ControllerBase 
    {
        private IStokData _stokData;
        public StokController(IStokData stokData)
        {
            _stokData = stokData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetStoklar()
        {
            return Ok(_stokData.GetStoklar());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetStok(Guid id)
        {
            var stok = _stokData.GetStok(id);
            if (stok != null)
            {
                return Ok(stok);
            }
            return NotFound($"Stok with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult PostStok(Stok stok)
        {
            _stokData.AddStok(stok);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + stok.Id,
                stok);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteStok(Guid id)
        {
            var stok = _stokData.GetStok(id);
            if (stok != null)
            {
                _stokData.DeleteStok(stok);
                return Ok();
            }

            return NotFound($"Stok with Id: {id} was not found");


        }

        //[HttpPatch]
        //[Route("api/[controller]/{id}")]
        //public IActionResult EditStok(Guid id,Stok stok)
        //{
        //    var existingstok = _stokData.GetStok(id);
        //    if (existingstok != null)
        //    {
        //        stok.Id = existingstok.Id;
        //        _stokData.EditStok(stok);
        //    }

        //    return Ok(stok);

        //}
    }
}
