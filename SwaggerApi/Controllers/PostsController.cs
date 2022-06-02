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

namespace SwaggerApi.Controllers
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
        public IActionResult GetAllPosts()
        {
            var result = _postService.GetAllPosts();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getallbycategory")]
        public IActionResult GetAllByCategory(int cateogryId)
        {
            var result = _postService.GetAllByCategory(cateogryId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getallwithimage")]
        public IActionResult GetAllImagePosts()
        {
            var result = _postService.GetAllImagePosts();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getallwithtext")]
        public IActionResult GetAllTextPosts()
        {
            var result = _postService.GetAllTextPosts();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getallwithvideo")]
        public IActionResult GetAllVideosPosts()
        {
            var result = _postService.GetAllVideosPosts();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getallwithvoice")]
        public IActionResult GetAllVoicePosts()
        {
            var result = _postService.GetAllVoicePosts();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getimagepostbycustomer")]
        public IActionResult GetImagePostByCustomerId(int id)
        {
            var result = _postService.GetImagePostByCustomerId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("gettextpostbycustomer")]
        public IActionResult GetTextPostByCustomerId(int id)
        {
            var result = _postService.GetTextPostByCustomerId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getvideopostbycustomer")]
        public IActionResult GetVideosPostByCustomerId(int id)
        {
            var result = _postService.GetVideosPostByCustomerId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getvoicepostbycustomer")]
        public IActionResult GetVoicePostByCustomerId(int id)
        {
            var result = _postService.GetVoicePostByCustomerId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _postService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getbycustomerandlatest")]
        public IActionResult GetByCustomerIdAndLatestDate(int customerId)
        {
            var result = _postService.GetByCustomerIdAndLatestDate(customerId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbydatelatest")]
        public IActionResult GetByDateLatest()
        {
            var result = _postService.GetByDateLatest();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Post post)
        {
            var result = _postService.Add(post);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Post post)
        {
            var result = _postService.Update(post);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Post post)
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
