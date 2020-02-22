using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderService.Models;
namespace OrderService.Repositories
{
   public interface OorderRepository
    {
        List<Orders> getall();
        Orders getbyid(string id);
       void add(Orders order);
        void delete(string id);
        void update(Orders order);
    }
}
