using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private IImageService _imageService;

        public ImagesController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpGet("getall")]
        IActionResult GetAll()
        {
            var result = _imageService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        IActionResult GetById(int id)
        {
            var result = _imageService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        IActionResult Add([FromForm(Name = "Image")] IFormFile file, [FromForm] Image image)
        {
            var result = _imageService.Add(file, image);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        IActionResult Update([FromForm(Name = "Image")] IFormFile file, [FromForm] Image image)
        {
            var result = _imageService.Update(file, image);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        IActionResult Delete(Image image)
        {
            var result = _imageService.Delete(image);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
