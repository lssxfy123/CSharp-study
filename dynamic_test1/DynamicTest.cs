// Copyright 2016.刘珅珅
// author：刘珅珅
// dynamic用于反射
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace dynamic_test1
{
    class DynamicTest
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom("dll_test1.dll");
            Type[] all = asm.GetTypes();

            int i;
            for ( i = 0; i < all.Length; ++i)
                if (all[i].Name == "MyClass")
                    break;

            if (i == all.Length)
            {
                Console.WriteLine("MyClass not found in assembly.");
                return;
            }

            Type t = all[i];

            // 获取默认构造函数
            ConstructorInfo[] ci = t.GetConstructors();

            int j;
            for (j = 0; j < ci.Length; ++j)
                if (ci[j].GetParameters().Length == 0)
                    break;

            if (j == ci.Length)
            {
                Console.WriteLine("Default constructor not found.");
                return;
            }

            // 创建一个动态的MyClass对象
            dynamic obj = ci[j].Invoke(null);

            // 通过dynamic对象调用MyClass类的方法
            obj.IsEven(15);

        }
    }
}
