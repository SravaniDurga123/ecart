using System;
using System.Collections.Generic;
namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainee> L = new List<Trainee>();
            Console.WriteLine("enter no of trainees");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter trainee id");
                int trainee_id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter trainee name");
                string trainee_name = Console.ReadLine();
                Console.WriteLine("enter project id");
                int project_id = int.Parse(Console.ReadLine());
                L.Add(new Trainee(trainee_id, trainee_name, project_id));
            }
            List<Trainee> tl = L.FindAll(x => x.Project_id != -1);
            Console.WriteLine("names of trainee who doesn't have project is as -1");
            foreach (Trainee y in tl)
                Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
