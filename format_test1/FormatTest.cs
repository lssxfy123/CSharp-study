// Copyright 2016.刘珅珅
// author：刘珅珅
// 格式化
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace format_test1
{
    class FormatTest
    {
        static void Main(string[] args)
        {
            double v = 17688.65849;
            double d = 0.15366;
            int x = 21;

            // F定点记数，保留两位小数
            Console.WriteLine("{0:F2}", v);  // 17688.66
            string str = String.Format("{0:F2}", v);
            Console.WriteLine(str);  // 17688.66

            // N定点记数，使用逗号分隔符，保留5为小数
            Console.WriteLine("{0:N5}", v);  // 17,688.65849

            // E科学记数，默认保留6位小数
            Console.WriteLine("{0:e}", v);  // 1.768866e+004

            // P百分比记数，默认保留两位小数
            Console.WriteLine("{0:p}", d);  // 15.37%

            // X十六进制表示，只能显示整型数据
            // 长度最小为5位，不够补0
            Console.WriteLine("{0:X5}", x);  // 00015

            // D表示日期，只使用整数
            // 只能显示整型数据
            Console.WriteLine("{0:d3}", x);  // 021

            // C显示货币
            Console.WriteLine("{0:C}", 189.9);  // ￥189.90
        }
    }
}
