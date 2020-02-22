using OrderService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderService.Repositories;
    namespace OrderService.Repositories
{
    public class OrderRepository : OorderRepository
    {
        shopDBContext db;

        public OrderRepository(shopDBContext db)
        {
            this.db = db;
        }
        public void add(Orders order)
        {
            db.Add(order);
            db.SaveChanges();
        }

        public void delete(string id)
        {
            Orders o = db.Orders.Find(id);
            db.Remove(o);
            db.SaveChanges();
        }

        public List<Orders> getall()
        {
            return db.Orders.ToList();
        }

        public Orders getbyid(string id)
        {
            return db.Orders.Find(id);
        }

        public void update(Orders order)
        {
            db.Update(order);
            db.SaveChanges();
        }
    }
}
