// Copyright 2016.刘珅珅
// author：刘珅珅
// 接口的显式实现
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_test5
{
    public interface IEven
    {
        bool IsOdd(int x);
        bool IsEven(int x );
    }

    class MyClass : IEven
    {
        // 显式实现接口方法
        bool IEven.IsOdd(int x)
        {
            if ((x % 2) != 0)
            {
                return true;
            }
            return false;
        }

        public bool IsEven(int x)
        {
            IEven obj = this;
            return !obj.IsOdd(x);
            // return !this.IsOdd(x);  // error不能通过类对象来访问
        }
    }

    class InterfaceTest
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            bool result = obj.IsEven(4);
            if (result)
            {
                Console.WriteLine("4 is even");
            }

            // result = obj.IsOdd(4);  // error，不能访问显式实现的接口方法

            IEven iRef = (IEven)obj;
            result = iRef.IsOdd(3);
            if (result)
            {
                Console.WriteLine("3 is odd");
            }
        }
    }
}
