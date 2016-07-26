// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型委托的协变和逆变
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test15
{
    delegate bool Op<in T>(T obj);

    // error，逆变类型形参只能作为方法形参
    // delegate T Op1<in T>(T obj);

    delegate T AnotherOp<out T, V>(V obj);

    // error，协变类型形参只能为方法的返回值
    // delegate T AnotherOp1<out T, V>(T o, V obj);

    // OK，如果使用协变类型形参就必须做方法的返回值
    // 也可以不用协变类型形参
    // delegate bool AnotherOp1<out T, V>(V obj);

    class Alpha
    {
        public int Val { get; set; }
        public Alpha(int v) { Val = v; }
    }

    class Beta : Alpha
    {
        public Beta(int v) : base(v) { }
    }

    class GenericsTest
    {
        static bool IsEven(Alpha obj)
        {
            if ((obj.Val % 2) == 0)
                return true;
            return false;
        }

        static Beta ChangeIt(Alpha obj)
        {
            return new Beta(obj.Val + 2);
        }

        static void Main(string[] args)
        {
            Alpha objA = new Alpha(4);
            Beta objB = new Beta(9);

            Op<Alpha> del_alpha = IsEven;

            // 逆变
            Op<Beta> del_beta = del_alpha;

            Console.WriteLine(del_alpha(objA));

            Console.WriteLine(del_beta(objB));

            AnotherOp<Beta, Alpha> del_another_beta = ChangeIt;

            // 协变
            AnotherOp<Alpha, Alpha> del_another_alpha = del_another_beta;
            objA = del_another_alpha(objA);
            Console.WriteLine(objA.Val);
        }
    }
}
