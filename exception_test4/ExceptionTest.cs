// Copyright 2016.刘珅珅
// author：刘珅珅
// 派生异常类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_test4
{
    class ExceptionTest
    {
        class RangeArrayException : Exception
        {
            public RangeArrayException() : base() { }
            public RangeArrayException(string message) : base(message) { }
            public RangeArrayException(string message, Exception inner_exception) 
                : base(message, inner_exception) { }
            public RangeArrayException(System.Runtime.Serialization.SerializationInfo info,
                                                           System.Runtime.Serialization.StreamingContext context)
                : base(info, context) { }

            public override string ToString()
            {
                return Message;
            }
        }

        class RangeArray
        {
            int[] array;
            int lower_bound;
            int upper_bound;

            public int Length { get; private set; }

            public RangeArray(int low, int high)
            {
                ++high;
                if (high <= low)
                {
                    throw new RangeArrayException("Low index not less than high.");
                }

                array = new int[high - low];
                Length = high - low;
                lower_bound = low;
                upper_bound = --high;
            }

            public int this[int index]
            {
                get
                {
                    if (Ok(index))
                    {
                        return array[index - lower_bound];
                    }
                    else
                    {
                        throw new RangeArrayException("Range Error.");
                    }
                }

                set
                {
                    if (Ok(index))
                    {
                        array[index - lower_bound] = value;
                    }
                    else
                    {
                        throw new RangeArrayException("Range Error.");
                    }
                }
            }

            private bool Ok(int index)
            {
                if (index >= lower_bound && index <= upper_bound)
                {
                    return true;
                }
                return false;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                RangeArray obj1 = new RangeArray(-2, 2);
                for (int i = -2; i < 10; ++i)
                {
                    Console.WriteLine(obj1[i]);
                }
            }
            catch (RangeArrayException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
