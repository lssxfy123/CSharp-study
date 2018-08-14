// string.Format双重引号
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace string_format_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp = string.Format("abcde{0}, aeeljl'{1}'aaljal\"{2}\"ljljl", "ABC", "DEF", "OMG");
            Console.WriteLine(tmp);
        }
    }
}
