using System;
using System.Collections.Generic;
using System.Text;

namespace PartialDemo
{
   partial class ClassA
    {
        partial void setData()
        {
            Console.WriteLine("data is assigned using partial");
        }
    }
}
