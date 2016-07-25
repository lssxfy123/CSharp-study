// Copyright 2016.刘珅珅
// author：刘珅珅
// 特性：命名形参
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace attribute_test1
{
    // 特性类命名通常以Attribute结束
    [AttributeUsage(AttributeTargets.All)]
    public class RemarkAttribute : Attribute
    {
        string remark;
        public string supplement;

        public RemarkAttribute(string comment)
        {
            remark = comment;
            supplement = "None";
            Priority = 1;
        }

        public string Remark
        {
            get
            {
                return remark;
            }
        }

        public int Priority { get; set; }
    }

    // 特性的命名形参
    // 只有公有的、可读写的字段和属性才可以用作命名形参
    [RemarkAttribute("This class uses an attribute.",
                                  supplement = "This is additional info.",
                                  Priority = 10)]
    class UseAttrib
    {
    }

    class AttributeTest
    {
        static void Main(string[] args)
        {
            Type t = typeof(UseAttrib);

            // 获取类型的特性，false表示不获取继承的特性
            object[] attribs = t.GetCustomAttributes(false);
            foreach (object obj in attribs)
            {
                Console.WriteLine(obj);
            }

            Type remark_att = typeof(RemarkAttribute);
            RemarkAttribute ra = (RemarkAttribute)Attribute.GetCustomAttribute(t, remark_att);

            Console.Write("Remark: ");
            Console.WriteLine(ra.Remark);

            Console.Write("supplement: ");
            Console.WriteLine(ra.supplement);

            Console.WriteLine("Priority: " + ra.Priority);
        }
    }
}
