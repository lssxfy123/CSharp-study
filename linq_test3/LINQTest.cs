// Copyright 2016.刘珅珅
// author：刘珅珅
// LINQ查询：多组orderby排序
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_test3
{
    class Account
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double Balance { get; private set; }
        public string AccountNumber { get; private set; }

        public Account(string fn, string ln, double bal, string accnum)
        {
            FirstName = fn;
            LastName = ln;
            Balance = bal;
            AccountNumber = accnum;
        }
    }

    class LINQTest
    {
        static void Main(string[] args)
        {
            // 对象初始化器
            Account[] accounts = { new Account("Tom", "Smith", 100.23, "132CK"),
                                                 new Account("Tom", "Smith", 1000.23, "132CD"),
                                                 new Account("Ralph", "Jones", 1923.85, "436CD"),
                                                 new Account("Ralph", "Jones", 987.12, "436MM"),
                                                 new Account("Ted", "Krammer", 3223.19, "897CD"),
                                                 new Account("Ralph", "Jones", -123.32, "434CK"),
                                                 new Account("Sara", "Smith", 5017.40, "543MM"),
                                                 new Account("Sara", "Smith", 3495.79, "547CD"),
                                 };

            var account_info = from acc in accounts
                               orderby acc.LastName, acc.FirstName, acc.Balance
                               select acc;

            Console.WriteLine("Accounts in sorted order: ");

            string temp = "";

            // 执行查询
            foreach (Account acc in account_info)
            {
                if (temp != acc.FirstName)
                {
                    Console.WriteLine();
                    temp = acc.FirstName;
                }

                Console.WriteLine("{0}, {1}\tAcc#: {2}, {3, 10:C}",
                                                acc.LastName, acc.FirstName, 
                                                acc.AccountNumber, acc.Balance);
            }
        }
    }
}
