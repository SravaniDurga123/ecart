using System;
using HandsOnEFcodefirst.context;
using HandsOnEFcodefirst.Models;
using System.Linq;
using System.Collections.Generic;
namespace HandsOnEFcodefirst
{
    class Program
    {
        static void Main(string[] args)
        {
           using(mycontext db=new mycontext())
            {
            //    student s = new student() { sname = "vishal", age = 5, sid = "s002" };
            //    db.students.Add(s);
            //    db.SaveChanges();

                // fetch the record
                //student s = db.students.Find(1);
                //Console.WriteLine("welcome {0}",s.sname);

                //fecth one record using non primary key
                //student s = db.students.SingleOrDefault(e => e.sname == "vishal");
                //Console.WriteLine(s.sid);
                //List<student> list = db.students.Where(e => e.age == 5).ToList();
                //List<student> list1 = db.students.Where(e => e.age == 5 && e.sid=="s001").ToList();

                //update record
                student s2 = db.students.Find(1);
                s2.age = 21;
                db.students.Update(s2);
                db.SaveChanges();

                student s3 = db.students.SingleOrDefault(e => e.sname == "vishal");
                db.students.Remove(s3);
                db.SaveChanges();

            }
        }
    }
}
