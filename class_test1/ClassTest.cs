using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test1
{
    class Build
    {
        public int floors_;
        public int area_;

        public Build()
        {
            floors_ = 1;
            area_ = 2;
        }
    }

    class ClassTest
    {
        static void Main()
        {
            // 1. 声明一个Build类类型的变量house
            // 2. 创建一个实际的、物理的对象
            // 3. 将该对象的引用赋给house，house变量引用Build类型的对象
            Build house = new Build();

            // house1与house引用同一个对象
            // 一个变量的改动会反映到另一个变量上
            Build house1 = house;
            house.area_ = 100;
            Console.WriteLine(house.area_);  // 100
            Console.WriteLine(house1.area_);  // 100

            house1.floors_ = 1000;
            Console.WriteLine(house.floors_);  // 1000
            Console.WriteLine(house1.floors_);  // 1000

            // 改变house1的引用对象，house1和house之间就没有任何关联了
            Build house2 = new Build();
            house1 = house2;
            house2.floors_ = 5000;
            Console.WriteLine(house.floors_);  // 1000
            Console.WriteLine(house1.floors_);  // 5000
            Console.WriteLine(house2.floors_);  // 5000
        }
    }
}
