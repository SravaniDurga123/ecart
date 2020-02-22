using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ItemServices.Repository;
using ItemServices.Models;
namespace ItemServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository rep;
        public ItemController(IItemRepository rep)
        {
            this.rep = rep;
        }
        [HttpGet]
        [Route("GetItems")]
        public IActionResult GetItems()
        {
            try
            {
                return Ok(rep.GetAllItems());
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                return Ok(rep.GetByID(id));
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(Items obj)
        {
            try
            {
                rep.AddItem(obj);
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
                rep.DeleteItem(id);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPut]
        [Route("update")]
        public  IActionResult update(Items item)
        {
            try
            {
                rep.updateItem(item);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}