using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIDemo2.Models;
namespace HandsOnAPIDemo2.Repository
{
    public class EmployeeRepository
    {
        public List<Employee> getall()
        {
            using(EMSDBContext db=new EMSDBContext())
            {
                return db.Employee.ToList();
            }
        }
        public Employee getbyid(string id)
        {
           using(EMSDBContext db=new EMSDBContext())
            {
                return db.Employee.Find(id);
            }
        }
        public void add(Employee item)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                db.Add(item);
                db.SaveChanges();
            }
        }
        public void update(Employee item)
        {
            using(EMSDBContext db=new EMSDBContext())
            {
                db.Update(item);
                db.SaveChanges();
            }
        }
    }
}
