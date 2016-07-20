// Copyright 2016.刘珅珅
// author：刘珅珅
// 自动实现属性
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_test2
{
    class FailSoftArray
    {
        int[] array;

        public FailSoftArray(int size)
        {
            array = new int[size];
            Length = size;
        }

        public int this[int index]
        {
            get
            {
                if (Ok(index))
                {
                    Error = false;
                    return array[index];
                }
                else
                {
                    Error = true;
                    return 0;
                }
            }

            set
            {
                if (Ok(index))
                {
                    array[index] = value;
                    Error = false;
                }
                else
                {
                    Error = true;
                }
            }
        }

        // 自动实现属性
        public int Length
        {
            get;
            private set;
        }

        public bool Error
        {
            get;
            private set;
        }

        private bool Ok(int index)
        {
            if (index >= 0 && index < Length)
            {
                return true;
            }
            return false;
        }
    }

    class AutoPropertyTest
    {
        static void Main(string[] args)
        {
            FailSoftArray fs = new FailSoftArray(5);

            for (int i = 0; i < fs.Length + 1; ++i)
            {
                fs[i] = i + 1;
                if (fs.Error)
                {
                    Console.WriteLine("Error with index " + i);
                }
            }
        }
    }
}
