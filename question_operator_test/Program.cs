// Copyright 2018.刘珅珅
// author：刘珅珅
// ?.和?[]运算符
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question_operator_test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = null;
            // 如果list为null则返回null
            var length = list?.Count;  // length类型为int?，值为null
            var first = list?[0];  // first类型为int?，值为null
        }
    }
}
