using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductBussiness.Services;
using ProductEntity;
using System.Collections.Generic;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizesController : ControllerBase
    {
        private SizeServices _sizeService;
        public SizesController(SizeServices sizeService)
        {
            _sizeService = sizeService;
        }
        [HttpGet("GetSizes")]
        public IEnumerable<Sizes> GetSizes()
        {
            return _sizeService.GetSizes();
        }
        [HttpGet("GetSizeById")]
        public Sizes GetSizeById(int sizeId)
        {
            return _sizeService.GetSizeByid(sizeId);
        }
        [HttpPost("AddSize")]
        public IActionResult AddSize([FromBody] Sizes size)
        {
            _sizeService.AddSize(size);
            return Ok("Size created successfully!!");
        }
    }
}
