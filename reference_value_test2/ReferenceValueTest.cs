// Copyright 2016.刘珅珅
// author：刘珅珅
// 引用类型和值类型
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_value_test2
{
    public class NestedValueInRef
    {
        // a作为引用类型实例的一部分将分配在托管堆上
        private int a;
    }

    public struct ValueTypeStruct
    {
        private object _referenceType;
    }

    class ReferenceValueTest
    {
        static void Main(string[] args)
        {
            // ValueTypeStruct的局部变量obj分配在栈上
            // 它的_referenceType字段对应的实例分配在托管堆上，其引用
            // 位于栈上被obj持有
            ValueTypeStruct obj = new ValueTypeStruct();
        }
    }
}
