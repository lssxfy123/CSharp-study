// Copyright 2016.刘珅珅
// author：刘珅珅
// 计数类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class CountDown
    {
        int val;

        public CountDown(int n)
        {
            val = n;
        }

        public void Reset(int n)
        {
            val = n;
        }

        public int Count()
        {
            if (val > 0)
            {
                return --val;
            }
            else
            {
                return 0;
            }
        }
    }
}
