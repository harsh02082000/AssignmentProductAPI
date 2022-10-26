using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBussiness.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        private ColourServices _colourService;
        public ColoursController(ColourServices colourService)
        {
            _colourService = colourService;
        }
        [HttpGet("GetColours")]
        public IEnumerable<Colour> GetColours()
        {
            return _colourService.GetColours();
        }
        [HttpGet("GetColourById")]
        public Colour GetColourById(int colourId)
        {
            return _colourService.GetColourByid(colourId);
        }
        [HttpPost("AddColour")]
        public IActionResult AddColour([FromBody] Colour colour)
        {
            _colourService.AddColour(colour);
            return Ok("Colour created successfully!!");
        }
    }
}
