// Copyright 2016.刘珅珅
// author：刘珅珅
// 反射：获取方法
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace reflection_test2
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
            x = a;
            y = b;
        }

        public void Show()
        {
            Console.WriteLine("x : {0}, y : {1}", x, y);
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private method.");
        }
    }

    class ReflectionTest
    {
        static void Main(string[] args)
        {
            Type t = typeof(MyClass);

            Console.WriteLine("Methods supported: ");

            // 获取类自定义的公共的实例方法
            // 这里使用|运算符连接更改的标记
            // 不能使用&运算符
            MethodInfo[] method_info = t.GetMethods(BindingFlags.DeclaredOnly
                                                                                      | BindingFlags.Instance
                                                                                      | BindingFlags.Public);

            // 被MyClass支持的方法
            // 包含自身的所有方法以及继承的公有非静态方法
            // 不包含构造函数和析构函数
            foreach (MethodInfo m in method_info)
            {
                Console.Write(" " + m.ReturnType.Name + " " + m.Name + " (");

                // 方法参数
                ParameterInfo[] parameter_info = m.GetParameters();

                for (int i = 0; i < parameter_info.Length; ++i)
                {
                    Console.Write(parameter_info[i].ParameterType.Name + " " + parameter_info[i].Name);
                    if (i + 1 < parameter_info.Length)
                    {
                        Console.Write(", ");
                    }
                }
                //foreach (ParameterInfo p in parameter_info)
                //{
                //    Console.Write(p.ParameterType.Name + " " + p.Name);
                //    Console.Write(", ");
                //}

                Console.WriteLine(")");
            }
        }
    }
}
