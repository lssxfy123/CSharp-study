// Copyright 2016.刘珅珅
// author：刘珅珅
// 指针的运算
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsafe_test3
{
    class PointerTest
    {
        static void Main(string[] args)
        {
            int n = 2;
            int m = 3;
            int k = 20;

            unsafe
            {
                int* n_ptr = &n;

                // 将指针指向的地址显示成十六进制
                Console.WriteLine("original n_ptr address is {0:X4}", (int)n_ptr);

                ++n_ptr;
                Console.WriteLine("++n_ptr address is {0:X4}", (int)n_ptr);

                --n_ptr;
                Console.WriteLine("--n_ptr address is {0:X4}", (int)n_ptr);
            }

            Console.WriteLine();

            unsafe
            {
                int* m_ptr = &m;
                int* k_ptr = &k;

                Console.WriteLine("original m_ptr address is {0:X4}", (int)m_ptr);
                Console.WriteLine("original k_ptr address is {0:X4}", (int)k_ptr);

                Console.WriteLine();

                long x = m_ptr - k_ptr;

                Console.WriteLine("m_ptr - k_ptr  is {0}", x);

                m_ptr = m_ptr + 9;
                Console.WriteLine("m_ptr + 9 address is {0:X4}", (int)m_ptr);

                m_ptr = m_ptr - 5;
                Console.WriteLine("m_ptr - 5 address is {0:X4}", (int)m_ptr);
                Console.WriteLine("*m_ptr " + *m_ptr);  // 随机数

                void* v_ptr = &m;
                // ++v_ptr;  // error，void指针不能进行算法运算
                // Console.WriteLine("*v_ptr " + *v_ptr);  // error，不能解析void指针

                long d = 10;
                m_ptr = m_ptr + d;
                Console.WriteLine("m_ptr - 5 address is {0:X4}", (int)m_ptr);
            }
        }
    }
}
