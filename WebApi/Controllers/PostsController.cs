using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("getall")]
        IActionResult GetAllPosts()
        {
            var result = _postService.GetAllPosts();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getallwithimage")]
        IActionResult GetAllImagePosts()
        {
            var result = _postService.GetAllImagePosts();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getallwithtext")]
        IActionResult GetAllTextPosts()
        {
            var result = _postService.GetAllTextPosts();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getallwithvideo")]
        IActionResult GetAllVideosPosts()
        {
            var result = _postService.GetAllVideosPosts();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getallwithvoice")]
        IActionResult GetAllVoicePosts()
        {
            var result = _postService.GetAllVoicePosts();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getallwithimage")]
        IActionResult GetImagePostByCustomerId(int id)
        {
            var result = _postService.GetImagePostByUserId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getallwithtext")]
        IActionResult GetTextPostByCustomerId(int id)
        {
            var result = _postService.GetTextPostByUserId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getvideopostbycustomer")]
        IActionResult GetVideosPostByCustomerId(int id)
        {
            var result = _postService.GetVideosPostByUserId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getvoicepostbycustomer")]
        IActionResult GetVoicePostByCustomerId(int id)
        {
            var result = _postService.GetVoicePostByUserId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getbyid")]
        IActionResult GetById(int id)
        {
            var result = _postService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getbycustomerandlatest")]
        IActionResult GetByCustomerIdAndLatestDate(int customerId)
        {
            var result = _postService.GetByUserIdAndLatestDate(customerId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbycustomerandlatest")]
        IActionResult GetByDateLatest()
        {
            var result = _postService.GetByDateLatest();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        IActionResult Add(Post post)
        {
            var result = _postService.Add(post);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        IActionResult Update(Post post)
        {
            var result = _postService.Update(post);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        IActionResult Delete(Post post)
        {
            var result = _postService.Delete(post);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }


    }
}
