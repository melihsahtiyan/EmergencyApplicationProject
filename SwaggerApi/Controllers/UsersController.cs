using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concrete;

namespace SwaggerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet("getall")]
        public IActionResult Get()
        {

            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _userService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyemail")]
        public IActionResult GetByEmail(string email)
        {
            var result = _userService.GetByMail(email);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        [HttpGet("getbyidentitynumber")]
        public IActionResult GetbyIdentityNumber(string identityNumber)
        {
            var result = _userService.GetByIdentityNumber(identityNumber);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }



        [HttpPost("add")]
        public IActionResult PostAdd(User user)
        {
            var result = _userService.Add(user);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);


        }


        [HttpPost("update")]
        public IActionResult PostUpdate(User user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);


        }


        [HttpPost("delete")]
        public IActionResult PostDelete(User user)
        {
            var result = _userService.Delete(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);


        }
    }
}
