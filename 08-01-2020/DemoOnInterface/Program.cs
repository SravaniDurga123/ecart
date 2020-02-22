using System;

namespace DemoOnInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            sbi s = new sbi("karappakam", "chennai", "sravani");
            s.display();
            s.getinterest();
            s.getgoldloan();
            kothak k = new kothak("shollingnallur", "chennai", "sravani");
            s.display();
            k.getinterest();
            k.displaydmat();
            Console.ReadKey();
        }
    }
}
