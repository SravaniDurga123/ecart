using System;
using System.IO;
namespace DemoOnBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream(@"D:\sravani\ram\b.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //BinaryWriter bw = new BinaryWriter(fs);
            //int i = 10;
            //char ch = 's';
            //string s = "hello";
            //bw.Write(i);
            //bw.Write(ch);
            //bw.Write(s);
            //bw.Close();
            //fs.Close();

            FileStream fs1 = new FileStream(@"D:\sravani\ram\b.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader bw1 = new BinaryReader(fs1);
            int x = bw1.ReadInt32();
            char y = bw1.ReadChar();
            string z = bw1.ReadString();
            Console.WriteLine(x + " " + y + " " + z);
           
            bw1.Close();
            fs1.Close();

            Console.ReadKey();

        }
    }
}
