// Copyright 2016.刘珅珅
// author：刘珅珅
// 抽象类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit_class_test4
{
    abstract class TwoDShape
    {
        double width_;
        double heigth_;

        public TwoDShape(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public double Width
        {
            get { return width_; }
            set { width_ = value < 0 ? -value : value; }
        }

        public double Height
        {
            get { return heigth_; }
            set { heigth_ = value < 0 ? -value : value; }
        }

        public void ShowDim()
        {
            Console.WriteLine("Width and height are " + Width + " and " + Height);
        }

        // 抽象方法
        public abstract double Area();
    }

    class Triangle : TwoDShape
    {
        string style_;

        public Triangle(string s, double w, double h) : base(w, h)
        {
            style_ = s;
        }

        // 实现抽象方法
        public override double Area()
        {
            return Width * Height / 2;
        }
    }

    class InheritClassTest
    {
        static void Main(string[] args)
        {
            // 抽象类不能定义对象，只能定义引用
            TwoDShape[] shapes = new TwoDShape[2];

            shapes[0] = new Triangle("right", 8.0, 12.0);
            shapes[1] = new Triangle("left", 4.0, 5.0);

            for (int i = 0; i < shapes.Length; ++i)
            {
                Console.WriteLine("Area is " + shapes[i].Area());
                Console.WriteLine();
            }
        }
    }
}
