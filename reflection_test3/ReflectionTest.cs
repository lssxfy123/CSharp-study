// Copyright 2016.刘珅珅
// author：刘珅珅
// 使用反射调用方法
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace reflection_test3
{
    class MyClass
    {
        int x;
        int y;

        public MyClass(int i, int j)
        {
            x = i;
            y = j;
        }

        public int Sum()
        {
            return x + y;
        }

        public bool IsBetween(int i)
        {
            if (x < i && i < y)
            {
                return true;
            }
            return false;
        }

        public void Set(int a, int b)
        {
            Console.WriteLine("Inside Set(int, int).");
            x = a;
            y = b;
            Show();
        }

        // 重载Set
        public void Set(double a, double b)
        {
            Console.WriteLine("Inside Set(double, double).");
            x = (int)a;
            y = (int)b;
            Show();
        }

        public void Show()
        {
            Console.WriteLine("x : {0}, y : {1}", x, y);
        }
    }

    class ReflectionTest
    {
        static void Main(string[] args)
        {
            Type t = typeof(MyClass);
            MyClass reflect_obj = new MyClass(10, 20);
            int val;

            Console.WriteLine("Invoking methods in " + t.Name);
            Console.WriteLine();

            MethodInfo[] method_info = t.GetMethods();

            foreach (MethodInfo m in method_info)
            {
                ParameterInfo[] param_info = m.GetParameters();

                if (m.Name.Equals("Set", StringComparison.Ordinal)
                    && param_info[0].ParameterType == typeof(int))
                {
                    object[] param_args = new object[param_info.Length];
                    param_args[0] = 9;
                    param_args[1] = 18;
                    m.Invoke(reflect_obj,  param_args);
                } else if (m.Name.Equals("Set", StringComparison.Ordinal)
                              && param_info[0].ParameterType == typeof(double)) 
                {
                    object[] param_args = new object[param_info.Length];
                    param_args[0] = 1.12;
                    param_args[1] = 23.4;
                    m.Invoke(reflect_obj, param_args);
                }
                else if (m.Name.Equals("Sum", StringComparison.Ordinal))
                {
                    val = (int)m.Invoke(reflect_obj, null);
                    Console.WriteLine("sum is " + val);
                }
            }
        }
    }
}
