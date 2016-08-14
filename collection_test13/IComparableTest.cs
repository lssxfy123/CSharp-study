// Copyright 2016.刘珅珅
// author：刘珅珅
// 非泛型集合中自定义类的比较
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test13
{
    class Inventory : IComparable
    {
        string name;
        double cost;
        int onhand;

        public Inventory(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }

        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1, 6:C} On hand: {2}",
                                                name, cost, onhand);
        }

        // 实现IComparable接口
        public int CompareTo(object obj)
        {
            Inventory b = (Inventory)obj;
            return name.CompareTo(b.name);
        }
    }

    class IComparableTest
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();

            array.Add(new Inventory("Pliers", 5.95, 3));
            array.Add(new Inventory("Wrenches", 8.29, 2));
            array.Add(new Inventory("Hammers", 3.50, 4));
            array.Add(new Inventory("Drills", 19.88, 8));

            Console.WriteLine("Inventory list before sorting:");
            foreach (Inventory i in array)
                Console.WriteLine(" " + i);

            Console.WriteLine();

            // 排序
            array.Sort();

            Console.WriteLine("Inventory list after sorting:");
            foreach (Inventory i in array)
                Console.WriteLine(" " + i);
        }
    }
}
