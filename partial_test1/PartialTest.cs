// Copyright 2016.刘珅珅
// author：刘珅珅
// 部分方法和部分类型
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_test1
{
     partial  class Base {
         public Base(int a, int b) 
         {
             X = a;
             Y = b;
         }

         partial void Show();
    }

     partial class Base
     {
         public int X { get; set; }
         partial void Show()
         {
             Console.WriteLine("{0}, {1}", X, Y);
         }
     }

     partial class Base
     {
         public int Y { get; set; }

         public void ShowXY()
         {
             Show();
         }
     }

    // 部分方法的声明和定义必须分开
     partial class Test
    {
        partial void Show();

        partial void Show() {}
    }

    // error，部分方法不能声明在部分接口中
    //partial interface Ip
    //{
    //    partial void Show();
    //}

    class PartialTest
    {
        static void Main(string[] args)
        {
            Base b = new Base(1, 2);
            b.ShowXY();
        }
    }
}
