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
                return Ok(result.Data);
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

        [HttpGet("getimagepostbyuser")]
        public IActionResult GetImagePostByUserId(int id)
        {
            var result = _postService.GetImagePostByUserId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("gettextpostbyuser")]
        public IActionResult GetTextPostByUserId(int id)
        {
            var result = _postService.GetTextPostByUserId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getvideopostbyuser")]
        public IActionResult GetVideosPostByUserId(int id)
        {
            var result = _postService.GetVideosPostByUserId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getvoicepostbyuser")]
        public IActionResult GetVoicePostByUserId(int id)
        {
            var result = _postService.GetVoicePostByUserId(id);
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


        [HttpGet("getbyuserandlatest")]
        public IActionResult GetByUserIdAndLatestDate(int customerId)
        {
            var result = _postService.GetByUserIdAndLatestDate(customerId);
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
                return Ok(result);
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
