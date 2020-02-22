using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        customerDbContext db = new customerDbContext();
        [HttpGet]
        [Route("GetAllCustomer")]
        public List<Customer> GetAll()
        {
            return db.Customer.ToList();
        }
        [HttpGet]
        [Route("GetCustomerById/{id}")]
        public Customer getById(int id)
        {
            return db.Customer.Find(id);
        }
        [HttpGet]
        [Route("GetCustomerByCity/{city}")]
        public List<Customer> getByCity(string city)
        {
            return db.Customer.Where(e=>e.City==city).ToList();
        }
        [HttpPost]
        [Route("addCustomer")]
        public void add(Customer c1)
        {
            db.Add(c1);
            db.SaveChanges();
        }
        [HttpPut]
        [Route("update/{id}")]
        public void update(int id)
        {
            Customer c = db.Customer.Find(id);
            c.City = "bhvm";
            c.Address = "hgdauyeq";
            db.Update(c);
            db.SaveChanges();
        }
    }
}