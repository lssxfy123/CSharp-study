// Copyright 2016.刘珅珅
// author：刘珅珅
// 接口属性与索引器
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_test3
{
    public interface ISeries
    {
        int Next
        {
            get;
            set;
        }

        int this[int index]
        {
            get;
        }
    }

    class ByTwos : ISeries
    {
        int val;

        public ByTwos()
        {
            val = 0;
        }

        public int Next
        {
            get
            {
                val += 2;
                return val;
            }

            set
            {
                val = value;
            }
        }

        public int this[int index]
        {
            get
            {
                val = 0;
                for (int i = 0; i < index; ++i)
                {
                    val += 2;
                }
                return val;
            }
        }
    }

    class InterfaceTest
    {
        static void Main(string[] args)
        {
            ByTwos obj = new ByTwos();

            Console.WriteLine("Next value is " + obj.Next);

            obj.Next = 20;

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("Next value is " + obj[i]);
            }
        }
    }
}
