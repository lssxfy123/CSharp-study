// Copyright 2016.刘珅珅
// author：刘珅珅
// 类的继承
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit_class_test1
{
    class TwoDShape
    {
        double width_;
        double height_;

        public TwoDShape()
        {
            Width = Height = 0.0;
        }

        public TwoDShape(double x)
        {
            Width = Height = x;
        }

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
            get { return height_; }
            set {height_ = value < 0 ? -value : value;}
        }

        public void ShowDim()
        {
            Console.WriteLine("Width and height are " + Width + " and " + Height);
        }
    }

    class Triangle : TwoDShape
    {
        string style_;

        public Triangle()  // 会默认调用基类的默认构造函数
        {
            style_ = "null";
        }

        public Triangle(double x) : base(x)
        {
            style_ = "isosceles";
        }

        // 通过base来调用基类的构造函数
        // 如果不通过base来调用，会自动调用默认构造函数
        // 这样会产生不可预料的后果
        public Triangle(string s, double w, double h) : base(w, h)
        {
            style_ = s;
        }

        public double Area()
        {
            return Width * Height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + style_);
        }
    }

    class InheritClassTest
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle("right", 8.0, 12.0);
            Triangle t3 = new Triangle(4.0);

            Console.WriteLine("Info for t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area is " + t1.Area());

            Console.WriteLine();

            Console.WriteLine("Info for t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area is " + t2.Area());

            Console.WriteLine();

            Console.WriteLine("Info for t3: ");
            t3.ShowStyle();
            t3.ShowDim();
            Console.WriteLine("Area is " + t3.Area());
        }
    }
}
