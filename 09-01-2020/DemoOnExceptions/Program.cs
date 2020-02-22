using System;

namespace DemoOnExceptions
{
    public class SalaryException : Exception
    {
       public SalaryException(string s) : base(s)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee("sravani", "123", 0);
            try
            {
                if (emp.salary == 0) throw new SalaryException("salary can be zero");
               
            }
            catch(SalaryException e)
            {
                Console.WriteLine(e.Message);
            }











            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt.AddDays(56));
            //try
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    Console.WriteLine(n / 2);
            //    try
            //    {

            //        int[] a = new int[3] { 1, 2, 3 };
            //        Console.WriteLine(a[5]);
            //    }
            // }
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            //}
            //finally
            //{
            //    Console.WriteLine("program ended");
            //}
            //Console.ReadKey();
        }
    }
}
