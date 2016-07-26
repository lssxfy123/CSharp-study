// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型接口的逆变
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test13
{
    public interface IMyContraVarGen<in T>
    {
        // 逆变类型形参只能应用于方法实参
        void Show(T obj);
    }

    class MyClass<T> : IMyContraVarGen<T>
    {
        public void Show(T x) 
        { 
            // 会自动调用T的ToString()方法
            Console.WriteLine(x); 
        }
    }

    class Alpha
    {
        // 重写object中的ToString()
        public override string ToString()
        {
            return "This is an Alpha object.";
        }
    }

    class Beta : Alpha
    {
        public override string ToString()
        {
            return "This is a Beta object.";
        }
    }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            IMyContraVarGen<Alpha> alpha_ref = new MyClass<Alpha>();

            IMyContraVarGen<Beta> beta_ref = new MyClass<Beta>();

            // 因为逆变，所以可以给接口的引用的类型参数赋一个基类类型
            IMyContraVarGen<Beta> beta_ref2;
            beta_ref2 = new MyClass<Alpha>();

            beta_ref.Show(new Beta());

            // 在断点调试时，看到beta_ref2的类型形参T的实际类型为Alpha
            // Show方法能接收一个Beta对象是因为T是逆变，Beta可以转换为Alpha
            // 但不清楚Show方法不能接收一个Alpha对象？？
            beta_ref2.Show(new Beta());

            // error，在编译时报错beta_ref2在编译时T为beta;
            // beta_ref2.Show(new Alpha());
        }
    }
}
