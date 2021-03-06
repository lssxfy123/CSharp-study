﻿// Copyright 2016.刘珅珅
// author：刘珅珅
// LINQ：匿名类型
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_test11
{
    class Item
    {
        public string Name { get; set; }
        public int ItemNumber { get; set; }

        public Item(string n, int num)
        {
            Name = n;
            ItemNumber = num;
        }
    }

    class InStockStatus
    {
        public int ItemNumber { get; set; }
        public bool InStock { get; set; }

        public InStockStatus(int n, bool b)
        {
            ItemNumber = n;
            InStock = b;
        }
    }

    class LINQTest
    {
        static void Main(string[] args)
        {
            Item[] items = {
                               new Item("Pliers", 1424),
                               new Item("Hammer", 7892),
                               new Item("Wrench", 8534),
                               new Item("Saw", 6411)
                           };

            InStockStatus[] status = {
                                         new InStockStatus(1424, true),
                                         new InStockStatus(7892, false),
                                         new InStockStatus(8534, true),
                                         new InStockStatus(6411, true)
                                     };

            // join子句连接两个序列
            // 匿名类型
            var stock_list = from item in items
                             join entry in status
                             on item.ItemNumber equals entry.ItemNumber
                             select new { Name = item.Name, InStock = entry.InStock };
                            // 下面的代码执行的效果与上面的相同
                            // 这是投射初始化器，item.Name和entry.InStock
                            // 会自动生成为匿名类型的Name和InStock
                            //  select new { item.Name, entry.InStock };

            Console.WriteLine("Item\tAvaiable\n");

            // 执行查询
            foreach (var t in stock_list)
                Console.WriteLine("{0}\t{1}", t.Name, t.InStock);
        }
    }
}
