// Copyright 2016.刘珅珅
// author：刘珅珅
// 在构造函数中调用虚函数
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit_class_test5
{
    class Base
    {
        public Base()
        {
            Show();
        }

        public virtual void Show()
        {
            Console.WriteLine("Show Base");
        }
    }

    class Derived : Base
    {
        public Derived()
        {

        }

        public override void Show()
        {
            Console.WriteLine("Show Derived");
        }
    }

    class InheritClassTest
    {
        static void Main()
        {
            Derived obj = new Derived();
        }
    }
}
