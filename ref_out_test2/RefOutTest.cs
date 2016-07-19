// Copyright 2015.
// author：刘珅珅
// ref和out修饰引用类型参数
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_test2
{
    class RefSwap
    {
        int a, b;
        public RefSwap(int i, int j)
        {
            a = i;
            b = j;
        }

        public void Show()
        {
            Console.WriteLine("a: {0}, b: {1}", a, b);
        }

        public void Swap(RefSwap obj1, RefSwap obj2)
        {
            RefSwap temp;
            temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }

        public void SwapRef(ref RefSwap obj1, ref RefSwap obj2)
        {
            RefSwap temp;
            temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }
    }
    class RefOutTest
    {
        static void Main(string[] args)
        {
            RefSwap x = new RefSwap(1, 2);
            RefSwap y = new RefSwap(3, 4);

            Console.Write("x before call: ");  // 1, 2
            x.Show();
            Console.Write("y before call: ");  // 3, 4
            y.Show();

            Console.WriteLine();

            // not ref
            x.Swap(x, y);
            Console.Write("not ref x after call: ");  // 1, 2
            x.Show();
            Console.Write("not ref y after call: ");  // 3, 4
            y.Show();

            Console.WriteLine();

            // ref
            x.SwapRef(ref x, ref y);
            Console.Write("ref x after call: ");  // 3, 4
            x.Show();
            Console.Write("ref y after call: ");  // 1, 2
            y.Show();
        }
    }
}
