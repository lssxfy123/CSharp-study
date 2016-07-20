// Copyright 2016.刘珅珅
// author：刘珅珅
// 在基类构造函数中调用虚函数
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit_class_test6
{
    class Base
    {
        private int b;

        public Base()
        {
            Show();
        }

        public virtual void Show()
        {
            b = 3;
            Console.WriteLine("Show Base " + b);
        }
    }

    class Derived : Base
    {
        public int d;

        public Derived()
        {
            d = 5;
        }

        public override void Show()
        {
            d = 4;
            Console.WriteLine("Show Derived " + d);
        }
    }

    //public class Base
    //{
    //    public Base()
    //    {
    //        System.Console.WriteLine("Base.Base");
    //        ABitDangerousCall();
    //    }

    //    public virtual void ABitDangerousCall()
    //    {
    //        System.Console.WriteLine("Base.ABitDangerousCall");
    //    }

    //    private class Inner
    //    {
    //        public Inner()
    //        {
    //            System.Console.WriteLine("Base.Inner.Inner");
    //        }
    //    }
    //    private Inner inner = new Inner();
    //}

    //class Derived : Base
    //{
    //    public Derived()
    //    {
    //        System.Console.WriteLine("Derived.Derived");
    //        ctorInitializedMember = 5;
    //    }

    //    // ctorInitializedMember is default initialized to zero before the constructor initializes it.
    //    private int ctorInitializedMember;
    //    private int derivedInt = 6;

    //    public override void ABitDangerousCall()
    //    {
    //        System.Console.WriteLine(String.Format("Derived.ABitDangerousCallctorInitializedMember={0} derivedInt={1}", ctorInitializedMember, derivedInt));
    //    }

    //    private class Inner
    //    {
    //        public Inner()
    //        {
    //            System.Console.WriteLine("Derived.Inner.Inner");
    //        }
    //    }
    //    private Inner inner = new Inner();
    //}

    class InheritClassTest
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            Console.WriteLine(d.d);  // 5
        }
    }
}
