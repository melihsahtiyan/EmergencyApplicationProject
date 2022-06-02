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
    public class SystemStavesController : ControllerBase
    {
        private ISystemStaffService _staffService;

        public SystemStavesController(ISystemStaffService staffService)
        {
            _staffService = staffService;
        }
        
        [HttpGet("getall")]
        IActionResult GetAll()
        {
            var result = _staffService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        IActionResult GetById(int id)
        {
            var result = _staffService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        IActionResult Add(SystemStaff staff)
        {
            var result = _staffService.Add(staff);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        IActionResult Delete(SystemStaff staff)
        {
            var result = _staffService.Delete(staff);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }


        [HttpPost("update")]
        IActionResult Update(SystemStaff staff)
        {
            var result = _staffService.Update(staff);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
