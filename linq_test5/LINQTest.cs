// Copyright 2016.刘珅珅
// author：刘珅珅
// LINQ查询：select子句
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_test5
{
    class ContactInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ContactInfo(string n, string a, string p)
        {
            Name = n;
            Email = a;
            Phone = p;
        }
    }

    class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public EmailAddress(string n, string a)
        {
            Name = n;
            Address = a;
        }
    }

    class LINQTest
    {
        static void Main(string[] args)
        {
            ContactInfo[] contacts = { 
                                         new ContactInfo("Herb", "Herb@HerbSchildt.com", "555-1010"),
                                         new ContactInfo("Tom", "Tom@HerbSchildt.com", "555-1101"),
                                         new ContactInfo("Sara", "Sara@HerbSchildt.com", "555-0101")
                                     };

            // select子句返回一个新的类型对象
            var email_list = from entry in contacts
                             select new EmailAddress(entry.Name, entry.Email);

            Console.WriteLine("The email list is");
            foreach (EmailAddress e in email_list)
                Console.WriteLine("{0}: {1}", e.Name, e.Address);
        }
    }
}
