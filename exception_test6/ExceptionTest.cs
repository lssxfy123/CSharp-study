// Copyright 2016.刘珅珅
// author：刘珅珅
// checked和unchecked
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_test6
{
    class ExceptionTest
    {
        static void Main(string[] args)
        {
            byte a = 12;
            byte b = 1;
            byte result;

            try
            {
                result = unchecked((byte)(a * b));
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
