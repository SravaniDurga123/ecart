using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Repositories;
using OrderService.Models;
namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        OorderRepository or;
        public OrderController(OorderRepository or)
        {
            this.or = or;
        }
        [HttpPost]
        [Route("add")]
        public IActionResult add(Orders order)
        {
            try
            {
                or.add(order);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }

        }
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult delete(string id)
        {
            try
            {
                or.delete(id);
                return Ok();
            }

            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpGet]
        [Route("getall")]
        public IActionResult getall()
        {
            try
            {
                return Ok(or.getall());
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult getbyid(string id)
        {
            try
            {
                return Ok(or.getbyid(id));
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPut]
        [Route("update")]
        public IActionResult update(Orders order)
        {
            try
            {
                or.update(order);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
       
    }
}