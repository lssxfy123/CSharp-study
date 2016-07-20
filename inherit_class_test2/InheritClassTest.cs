// Copyright 2016.刘珅珅
// author：刘珅珅
// 继承和名称隐藏
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit_class_test2
{
    class A
    {
        public int i = 0;
    }

    class B : A
    {
        // 派生类定义基类的同名成员
        new int i; 

        public B(int b)
        {
            i = b;  // i in B
        }

        public void Show()
        {
            Console.WriteLine("i in derived class: " + i);

            // 可以通过base来访问基类被隐藏的同名成员
            // i在基类中为public成员
            Console.WriteLine("i in base class: " + base.i);
        }
    }

    class InheritClassTest
    {
        static void Main(string[] args)
        {
            B obj = new B(2);
            obj.Show();
        }
    }
}
