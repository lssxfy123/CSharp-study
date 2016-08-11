// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型字典类：Dictionary
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test10
{
    class DictionaryTest
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();

            dict.Add("Bulter, John", 730);
            dict.Add("Swartz, Sarah", 590);
            dict.Add("Pyke, Thoms", 450);

            // 不能添加相同的key值
            // dict.Add("Bulter, John", 730);

            ICollection<string> keys = dict.Keys;

            foreach (string str in keys)
                Console.WriteLine("{0}, Salary: {1:C}", str, dict[str]);
        }
    }
}
