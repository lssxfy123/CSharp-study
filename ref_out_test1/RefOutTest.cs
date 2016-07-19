// Copyright 2016.刘珅珅
// author：刘珅珅
// ref和out改变值类型的传递
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_test1
{
    class RefTest
    {
        public void Sqr(ref int i)
        {
            i = i * i;
        }

        public void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }

    class OutTest
    {
        public int GetParts(double src, out double frac)
        {
            int whole;
            whole = (int)src;
            frac = src - whole;
            return whole;
        }
    }

    class RefOutTest
    {
        static void Main(string[] args)
        {
            RefTest obj = new RefTest();
            int a = 10;
            Console.WriteLine("a before call: " + a);  // 10
            // a必须初始化
            obj.Sqr(ref a);
            Console.WriteLine("a after call: " + a);  // 100

            int m = 10;
            int n = 6;
            Console.WriteLine("m before call: " + m);  // 10
            Console.WriteLine("n before call: " + n);  // 6
            obj.Swap(ref m, ref n);
            Console.WriteLine("m after call: " + m); // 6
            Console.WriteLine("n after call: " + n);  // 10

            double val = 3.56;
            double frac;
            OutTest obj1 = new OutTest();
            obj1.GetParts(val, out frac);
            Console.WriteLine("Fractional part is " + frac);   // 0.56
        }
    }
}
