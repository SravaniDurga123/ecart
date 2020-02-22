using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIDemo2.Repository;
using HandsOnAPIDemo2.Models;
namespace HandsOnAPIDemo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeRepository emp = new EmployeeRepository();
        [HttpGet]
        [Route("getall")]
        public IActionResult getall()
        {
            return Ok(emp.getall());
        }
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult getbyid(string id)
        {
            return Ok(emp.getbyid(id));
        }
        [HttpPost]
        [Route("add")]
        public IActionResult add(Employee item)
        {
            emp.add(item);
            return Ok();
        }
        [HttpPut]
        [Route("update")]
        public IActionResult update(Employee item)
        {
            emp.update(item);
            return Ok();
        }
    }
}