// Copyright 2016.刘珅珅
// author：刘珅珅
// Stack：栈
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test5
{
    class StackTest
    {
        static void ShowPush(Stack st, int a)
        {
            st.Push(a);
            Console.WriteLine("Push({0})", a);
            Console.Write("stack: ");
            foreach (int i in st)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        static void ShowPop(Stack st)
        {
            Console.Write("Pop -> ");
            int a = (int)st.Pop();
            Console.WriteLine(a);

            Console.Write("stack: ");
            foreach (int i in st)
                Console.Write(i + " ");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Stack stack = new Stack();

            ShowPush(stack, 22);
            ShowPush(stack, 65);

            ShowPop(stack);
            ShowPop(stack);

            try
            {
                // 栈弹出元素
                // 如果为空，抛出异常
                ShowPop(stack);
            } catch (InvalidOperationException)
            {
                Console.WriteLine("Stack empty.");
            }
        }
    }
}
