// Copyright 2016.刘珅珅
// author：刘珅珅
// 协变与逆变
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_test4
{
    class Base
    {
        public int val;
    }

    class Derived : Base { }

    delegate Base ChangeIt(Derived obj);

    class CoContraVariance
    {
        public Base IncrA(Base obj)
        {
            Base temp = new Base();
            temp.val = obj.val + 1;
            return temp;
        }

        public Derived IncrB(Derived obj)
        {
            Derived temp = new Derived();
            temp.val = obj.val + 1;
            return temp;
        }
    }

    class DelegateTest
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            CoContraVariance obj = new CoContraVariance();

            // 逆变：方法参数类型是委托参数类型的基类
            ChangeIt delegate_it = obj.IncrA;
            Base b = delegate_it(d);
            Console.WriteLine("Base: " + b.val);

            // 协变：方法返回类型是委托返回类型的派生类
            delegate_it = obj.IncrB;
            d = (Derived)delegate_it(d);
            Console.WriteLine("Derived: " + d.val);
        }
    }
}
