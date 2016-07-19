// Copyright 2016.刘珅珅
// author：刘珅珅
// 类和方法
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test2
{
    class MyClass
    {
        private int alpha;
        private int beta;
        public MyClass(int i, int j)
        {
            alpha = i;
            beta = j;
        }

        // MyClass类型的引用作为参数
        public bool SameAs(MyClass obj)
        {
            if ((obj.alpha == alpha) && (obj.beta == beta))
            {
                return true;
            }
            return false;
        }

        public void Copy(MyClass obj)
        {
            alpha = obj.alpha;
            beta = obj.beta;
        }

        public void Show()
        {
            Console.WriteLine("alpha: {0}, beta: {1}", alpha, beta);
        }
    }
    class ClassTest
    {
        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass(4, 5);
            MyClass obj2 = new MyClass(6, 7);

            Console.Write("obj1 : ");
            obj1.Show();

            Console.Write("obj2 : ");
            obj2.Show();

            obj1.Copy(obj2);

            if (obj1.SameAs(obj2))
            {
                Console.WriteLine("obj1 and obj2 have the same values");
            }
            else
            {
                Console.WriteLine("obj1 and obj2 have different values");
            }
        }
    }
}
