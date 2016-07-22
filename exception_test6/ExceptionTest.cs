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
            byte a = 127;
            byte b = 127;
            byte result;

            try
            {
                result = unchecked((byte)(a * b));
                Console.WriteLine("Unchecked result: " + result);

                result = checked((byte)(a * b));
                Console.WriteLine("Checked result: " + result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
