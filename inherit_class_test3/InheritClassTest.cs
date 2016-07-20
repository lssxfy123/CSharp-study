// Copyright 2016.刘珅珅
// author：刘珅珅
// 虚函数
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit_class_test3
{
    class Base
    {
        public virtual void Who()
        {
            Console.WriteLine("Who() in Base");
        }

        public virtual void In()
        {
            Console.WriteLine("In() in Base");
        }
    }

    class Derived : Base
    {
        public override void Who()
        {
            Console.WriteLine("Who() in Derived");
        }
    }

    class Derived2 : Derived
    {
        public override void In()
        {
            Console.WriteLine("In() in Derived2");
        }
    }


    class InheritClassTest
    {
        static void Main(string[] args)
        {
            Base base_obj = new Base();
            Derived de_obj = new Derived();
            Derived2 de_obj2 = new Derived2();

            base_obj.Who();
            base_obj.In();

            Console.WriteLine();

            Base base_ref1 = de_obj;
            base_ref1.Who();
            base_ref1.In();

            Console.WriteLine();

            Base base_ref2 = de_obj2;
            base_ref2.Who();
            base_ref2.In();
        }
    }
}
