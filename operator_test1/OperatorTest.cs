// Copyright 2016.刘珅珅
// author：刘珅珅
// 运算符重载
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_test1
{
    class DoubleD
    {
        int x;
        int y;

        public DoubleD() { x = y = 0; }
        public DoubleD(int i, int j) { x = i; y = j; }

        // 在C#中，前缀++和后缀++的重载相同
        public static DoubleD operator ++(DoubleD op)
        {
            DoubleD result = new DoubleD();
            result.x = op.x + 1;
            result.y = op.y + 1;
            return result;
        }

        public void Show()
        {
            Console.WriteLine(x + ", " + y);
        }
    }

    class OperatorTest
    {
        static void Main(string[] args)
        {
            DoubleD a = new DoubleD(1, 2);
            DoubleD resultA;

            // 执行后缀++重载运算符后，仍以原始值调用Show()
            a++.Show();  // 1, 2

            // 执行后缀++重载运算符后，会将结果本身赋给调用对象
            a.Show(); // 2, 3

            // 执行前缀++重载运算符后，直接将结果返回并修改对象本身
            resultA = ++a;
            resultA.Show();  // 3, 4
            a.Show();  // 3, 4

            // 执行后缀++重载运算符后，resultA接收的是修改之前的结果
            resultA = a++;
            resultA.Show();  // 3, 4
            a.Show();  // 4, 5
        }
    }
}
