// Copyright 2016.刘珅珅
// author：刘珅珅
// 不安全代码：指针访问结构体成员
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsafe_test2
{
    struct MyStruct
    {
        public int a;
        public int b;

        // 结构中如果包含引用类型，指针无法获取其地址
        // public string name;

        public int Sum() { return a + b; }
    }

    class PointerTest
    {
        static void Main(string[] args)
        {
            MyStruct obj = new MyStruct();

            unsafe
            {
                MyStruct* p = &obj;
                p->a = 10;
                p->b = 20;

                Console.WriteLine("Sum is " + p->Sum());
            }
        }
    }
}
