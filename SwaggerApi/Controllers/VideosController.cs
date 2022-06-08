using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace SwaggerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private IVideoService _videoService;

        public VideosController(IVideoService service)
        {
            _videoService = service;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _videoService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _videoService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyuserid")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _videoService.GetByUserId(userId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = "Video")] IFormFile file, [FromForm] Video video)
        {
            var result = _videoService.Add(video);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm] Video video)
        {
            var result = _videoService.Delete(video);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = "Video")] IFormFile file, [FromForm] Video video)
        {
            var result = _videoService.Update(video);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

    }
}
