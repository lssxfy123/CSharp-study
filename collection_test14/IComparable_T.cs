// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型比较接口：IComparable<T>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_test14
{
    class Inventory : IComparable<Inventory>
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

        // 实现IComparable<Inventory>接口
        public int CompareTo(Inventory obj)
        {
            return name.CompareTo(obj.name);
        }
    }

    class IComparable_T
    {
        static void Main(string[] args)
        {
            List<Inventory> list = new List<Inventory>();

            list.Add(new Inventory("Pliers", 5.95, 3));
            list.Add(new Inventory("Wrenches", 8.29, 2));
            list.Add(new Inventory("Hammers", 3.50, 4));
            list.Add(new Inventory("Drills", 19.88, 8));

            Console.WriteLine("Inventory list before sorting:");
            foreach (Inventory i in list)
                Console.WriteLine(" " + i);

            Console.WriteLine();

            // 排序
            list.Sort();

            Console.WriteLine("Inventory list after sorting:");
            foreach (Inventory i in list)
                Console.WriteLine(" " + i);
        }
    }
}
