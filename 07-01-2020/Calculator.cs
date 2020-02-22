using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        private int a;
        private int b;
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public int B { get => b; set => b = value; }
        public Calculator()
        {
            a = 1;
            b = 29;
        }
        public int add()
        {
            return a + b;
        }
        //public void swap(int a, int b)
        //{
        //    int c = a;
        //    a = b;
        //    b = c;

        //}
        public void swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;

        }
    }
}