using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.UrunlerData;

namespace WebApplication3.Controllers
{

    [ApiController]
    public class UrunlerController : ControllerBase
    {
        private IUrunlerData _urunlerData;
        public UrunlerController(IUrunlerData urunlerData)
        {
            _urunlerData = urunlerData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetUrunlers()
        {
            return Ok(_urunlerData.GetUrunlers());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetUrunler(Guid id)
        {
            var urunler = _urunlerData.GetUrunler(id);
            if (urunler != null)
            {
                return Ok(urunler);
            }
            return NotFound($"Urunler with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult PostUrunler(Urunler urunler)
        {
            _urunlerData.AddUrunler(urunler);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + urunler.Id,
                urunler);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteUrunler(Guid id)
        {
            var urunler = _urunlerData.GetUrunler(id);
            if (urunler != null)
            {
                _urunlerData.DeleteUrunler(urunler);
                return Ok();
            }

            return NotFound($"Urunler with Id: {id} was not found");


        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditUrunler(Guid id,Urunler urunler)
        {
            var existingurunler = _urunlerData.GetUrunler(id);
            if (existingurunler != null)
            {
                urunler.Id = existingurunler.Id;
                _urunlerData.EditUrunler(urunler);
            }

            return Ok(urunler);

        }
    }
}
