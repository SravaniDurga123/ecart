using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
             for (int i = 0; i < 9; i++)
             {
                 al.Add(i);
             }
             al.Add("hai");
             al.Add(7.56);
             al.Add(4.787);
             al.Add(4.787);
             //al.Remove(4);
             foreach (var i in al)
             Console.WriteLine(i);
             Console.WriteLine(al.Capacity);
             Console.WriteLine(al.Count);

             Queue q = new Queue();
             q.Enqueue("hai");
             q.Enqueue("jsfnk");
             q.Enqueue(1);
             q.Enqueue(4.567);
             q.Enqueue('f');
             Console.WriteLine(q.Dequeue());
             foreach (var val in q)
                 Console.WriteLine(val);

            //Stack
            Stack s = new Stack();
            s.Push(1);
            s.Push("hai");
            s.Push(23.123);
            s.Push('a');
            
            Console.WriteLine("deleted ele: "+s.Pop());
            Console.WriteLine("top element: "+s.Peek());
            foreach(var x in s)
                Console.WriteLine(x);

            //Hash Table
            Hashtable hs = new Hashtable();
            hs.Add("abc", 123);
            hs.Add(123, "xyz");
            hs.Add(1.23, 234);
            
            foreach(var x in hs.Keys)
            {
                Console.WriteLine(hs[x]);
            }
            Console.ReadKey();
            
        }

    }
}
