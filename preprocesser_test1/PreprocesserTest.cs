// Copyright 2016.刘珅珅
// author：刘珅珅
// 预处理器

// 必须定义在最顶端
#define EXPERIMENTAL

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preprocesser_test1
{
    class PreprocesserTest
    {
        static void Main(string[] args)
        {
#if EXPERIMENTAL
            Console.WriteLine("Complied for experimental version.");
#endif
            Console.WriteLine("This is in all versions.");
        }
    }
}
