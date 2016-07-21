// Copyright 2016.刘珅珅
// author：刘珅珅
// 捕获异常的顺序
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_test5
{
    class ExceptA : Exception
    {
        public ExceptA(string message) : base(message) { }
        public override string ToString()
        {
            return Message;
        }
    }

    class ExceptB : ExceptA
    {
        public ExceptB(string message) : base(message) { }
        public override string ToString()
        {
            return Message;
        }
    }

    class ExceptionTest
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; ++i)
            {
                try
                {
                    if (i == 0)
                    {
                        throw new ExceptA("Caught and ExceptA exception.");
                    }
                    else if (i == 1)
                    {
                        throw new ExceptB("Caught an ExceptB exception.");
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (ExceptB ex)
                {
                    Console.WriteLine(ex);
                }
                catch (ExceptA ex)
                {
                    Console.WriteLine(ex);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
