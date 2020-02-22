using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        practicedb1Context db = new practicedb1Context();
        [HttpGet]
        public List<Project> GetAll()
        {
            return db.Project.ToList();
        }
        [HttpGet("{id}")]
        [Route("GetById/{id}")]
        public Project GetById(string id)
        {
            return db.Project.SingleOrDefault(p=>p.ProjectNo==id);
        }
        [HttpGet("{name}")]
        [Route("GetByName/{name}")]
        public Project GetByName(string name)
        {
            return db.Project.SingleOrDefault(p => p.ProjectName == name);
        }
        [HttpPost]
        [Route("AddProject")]
        public void Add(Product item)
        {
            db.Product.Add(item);
            db.SaveChanges();
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public void delete(int id)
        {
           Product p = db.Product.Find(id) ;
            db.Remove(p);
            db.SaveChanges();
        }
        [HttpPut]
        [Route("update/{id}")]
        public void update(int id)
        {
            Product p = db.Product.Find(id) ;
            p.Stock = 6545;
            db.Update(p);
            db.SaveChanges();
        }
    }
}