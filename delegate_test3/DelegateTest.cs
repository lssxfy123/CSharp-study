// Copyright 2016.刘珅珅
// author：刘珅珅
// 多播委托
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_test3
{
    delegate void StringMethod(ref string s);

    class StringOps
    {
        public void ReplaceSpaces(ref string s)
        {
            Console.WriteLine("Replacing spaces with hyphens.");
            s = s.Replace(' ', '-');
        }

        public void RemoveSpaces(ref string s)
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
            s = temp;
        }

        public void Reverse(ref string s)
        {
            string temp = "";
            Console.WriteLine("Reversing string.");

            for (int j = 0, i = s.Length - 1; i >= 0; --i, ++j)
            {
                temp += s[i];
            }
            s = temp;
        }
    }

    class DelegateTest
    {
        static void Main(string[] args)
        {
            string str = "This is a test.";
            StringOps obj = new StringOps();

            StringMethod str_method;
            StringMethod replace = obj.ReplaceSpaces;
            StringMethod remove = obj.RemoveSpaces;
            StringMethod reverse = obj.Reverse;

            // 多播委托
            str_method = replace;
            str_method += reverse;

            // 先执行Replace，再执行Reverse
            str_method(ref str);
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();

            // 移除Replace
            str_method -= replace;

            // 增加Remove
            str_method += remove;

            str = "This is a test.";

            // 执行Reverse，再执行Remove
            str_method(ref str);
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();
        }
    }
}
