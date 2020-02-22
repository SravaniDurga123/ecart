using System;
using EFDAL;
using EFDAL.Models;
using EFDAL.context;
namespace EMSclient
{
    class Program
    {
        static void Main(string[] args)
        {
           //add new project
           using(MyContext db=new MyContext())
            {
                project p = new project() { pname = "djua" };
                db.Add(p);
                db.SaveChanges();
            }
        }
    }
}
