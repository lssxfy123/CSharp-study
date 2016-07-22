// Copyright 2016.刘珅珅
// author：刘珅珅
// 委托
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_test1
{
    delegate string StringMethod(string str);
    class DelegateTest
    {
        static string ReplaceSpaces(string s)
        {
            Console.WriteLine("Replacing spaces with hyphens.");
            return s.Replace(' ', '-');
        }

        static string RemoveSpaces(string s)
        {
            string temp = "";
            Console.WriteLine("Removing spaces.");

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] != ' ')
                {
                    temp += s[i];
                }
            }
            return temp;
        }

        static string Reverse(string s)
        {
            string temp = "";
            Console.WriteLine("Reversing string.");

            for (int j = 0, i = s.Length - 1; i >= 0; --i, ++j )
            {
                temp += s[i];
            }
            return temp;
        }

        static void Main(string[] args)
        {
            string str;
            StringMethod str_method = new StringMethod(ReplaceSpaces);

            str = str_method("This is a test.");
            Console.WriteLine("Replace result: " + str);

            Console.WriteLine();

            str_method = new StringMethod(RemoveSpaces);
            str = str_method("This is a test.");
            Console.WriteLine("Remove result: " + str);

            Console.WriteLine();

            str_method = new StringMethod(Reverse);
            str = str_method("This is a test.");
            Console.WriteLine("Reverse result: " + str);
        }
    }
}
