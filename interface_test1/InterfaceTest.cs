// Copyright 2016.刘珅珅
// author：刘珅珅
// 接口测试
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_test1
{
    public interface ISeries
    {
        int GetNext();
        void Reset();
        void SetStart(int x);
    }

    class ByTwos : ISeries
    {
        int start;
        int val;

        public ByTwos()
        {
            start = 0;
            val = 0;
        }

        public int GetNext()
        {
            val += 2;
            return val;
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }

    class InterfaceTest
    {
        static void Main(string[] args)
        {
            ByTwos obj = new ByTwos();

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("Next value is " + obj.GetNext());
            }
        }
    }
}
