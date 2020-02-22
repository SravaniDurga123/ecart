using System;
using System.IO;

namespace DemoOnFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d1 = new DirectoryInfo(@"D:\sravani\ram");
            if(d1.Exists==false)
         d1.Create();
         d1.CreateSubdirectory("ram");
            DirectoryInfo[] d = d1.GetDirectories();
            foreach(DirectoryInfo x in d)
            {
                Console.WriteLine(x.Name + " " + x.FullName + " " + x.CreationTime);
            }
            FileInfo[] f1 = d1.GetFiles();
            foreach(FileInfo x in f1)
            {
                Console.WriteLine(x.Name + " " + x.FullName + " " + x.CreationTime);
            }
            //FileStream fs = new FileStream(@"D:\sravani\ram\a.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("welcome");
            //for(int i = 0; i < 2; i++)
            //{
            //    string s = Console.ReadLine();
            //    sw.WriteLine(s);
            //}
            
            //sw.Close();
            //fs.Close();
            FileStream fs1 = new FileStream(@"D:\sravani\ram\a.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs1);
            string s;
            while ((s = (sr.ReadLine())) != null)
                Console.WriteLine(s);
            sr.Close();
            fs1.Close();

            Console.ReadKey();
        }
    }
}
