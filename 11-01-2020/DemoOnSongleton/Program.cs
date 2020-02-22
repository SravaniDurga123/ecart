using System;

namespace DemoOnSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton fromStudent = new Singleton(); 
            Singleton fromStudent = Singleton.getInstance;
            fromStudent.printDetails("sravani");
             Singleton fromEmployee= Singleton.getInstance;
           // Singleton fromEmployee = new Singleton(); 
            fromEmployee.printDetails("sravani");
        }
    }
}
