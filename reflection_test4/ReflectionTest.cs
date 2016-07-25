// Copyright 2016.刘珅珅
// author：刘珅珅
// 全自动类型查询
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace reflection_test4
{
    class ReflectionTest
    {
        static void Main(string[] args)
        {
            // 通过程序集获取类的声明
            Assembly asm = Assembly.LoadFrom("class_test3.exe");

            Type[] all_types = asm.GetTypes();
            foreach (Type temp in all_types)
            {
                Console.WriteLine("Found: " + temp.Name);
            }

            // 使用第一个类
            Type t = all_types[0];

            Console.WriteLine("Using: " + t.Name);

            // 获取构造函数
            ConstructorInfo[] constructor_info = t.GetConstructors();

            // 使用第一个构造函数
            ParameterInfo[] param_info = constructor_info[0].GetParameters();
            object reflect_obj;

            if (param_info.Length > 0)
            {
                object[] con_args = new object[param_info.Length];

                // 初始化构造参数
                for (int n = 0; n < param_info.Length; ++n)
                {
                    con_args[n] = 10 + n * 20;
                }
                reflect_obj = constructor_info[0].Invoke(con_args);
            }
            else
            {
                reflect_obj = constructor_info[0].Invoke(null);
            }

            Console.WriteLine("\nInvoking methods on reflect_obj");
            Console.WriteLine();

            // 忽略继承的方法
            MethodInfo[] method_info = t.GetMethods(BindingFlags.DeclaredOnly
                                                                                  | BindingFlags.Instance
                                                                                  | BindingFlags.Public);

            foreach (MethodInfo m in method_info)
            {
                Console.WriteLine("Calling {0} ", m.Name);

                ParameterInfo[] p_info = m.GetParameters();

                switch (p_info.Length)
                {
                    case 0:  // 无参
                        if (m.ReturnType == typeof(void))
                        {
                            m.Invoke(reflect_obj, null);
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
