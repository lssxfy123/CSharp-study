// Copyright 2016.刘珅珅
// author：刘珅珅
// 静态构造函数
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_structure_test1
{
    class StaticStructure
    {
        public static int alpha;
        public int beta;

        // 静态构造函数
        static StaticStructure()
        {
            alpha = 99;
            Console.WriteLine("Inside static constructor.");
        }

        public StaticStructure(int b)
        {
            beta = b;
            Console.WriteLine("Inside instance constructor");
        }

        public void Show()
        {
            Console.WriteLine("alpha: " + alpha);
            Console.WriteLine("beta: " + beta) ;
        }
    }
    class StaticStructureTest
    {
        static void Main(string[] args)
        {
            StaticStructure obj = new StaticStructure(20);
            obj.Show();

            Console.WriteLine();
            StaticStructure obj1 = new StaticStructure(30);
            obj1.Show();
        }
    }
}
