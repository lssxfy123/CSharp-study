// Copyright 2016.刘珅珅
// author：刘珅珅
// 委托：实例方法
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_test2
{
    delegate string StringMethod(string str);

    class StringOps
    {
        public string ReplaceSpaces(string s)
        {
            Console.WriteLine("Replacing spaces with hyphens.");
            return s.Replace(' ', '-');
        }

        public string RemoveSpaces(string s)
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

        public string Reverse(string s)
        {
            string temp = "";
            Console.WriteLine("Reversing string.");

            for (int j = 0, i = s.Length - 1; i >= 0; --i, ++j)
            {
                temp += s[i];
            }
            return temp;
        }
    }
    class DelegateTest
    {
        static void Main(string[] args)
        {
            StringOps obj = new StringOps();

            string str;

            // 委托的方法组转换
            StringMethod str_method = obj.ReplaceSpaces;
            str = str_method("This is a test.");
            Console.WriteLine("Replace result: " + str);
            Console.WriteLine();

            str_method = obj.RemoveSpaces;
            str = str_method("This is a test.");
            Console.WriteLine("Remove result: " + str);
            Console.WriteLine();

            str_method = obj.Reverse;
            str = str_method("This is a test.");
            Console.WriteLine("Reverse result: " + str);
        }
    }
}
