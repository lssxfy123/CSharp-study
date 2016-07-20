// Copyright 2016.刘珅珅
// author：刘珅珅
// 属性测试
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_test1
{
    class SimpleProperty
    {
        int prop;
        int[] array;
        int length;

        public SimpleProperty(int size)
        {
            array = new int[size];
            length = size;
        }

        // 读写属性
        public int MyProp
        {
            get
            {
                return prop;
            }

            set
            {
                if (value >= 0)
                {
                    prop = value;
                }
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
        }
    }

    class PropertyTest
    {
        static void Main(string[] args)
        {
            SimpleProperty obj = new SimpleProperty(5);

            obj.MyProp = 100;
            Console.WriteLine("Value of MyProp: " + obj.MyProp);
            Console.WriteLine("Value of Length: " + obj.Length);

            // obj.Length = 10;  // error，Length是只读属性
        }
    }
}
