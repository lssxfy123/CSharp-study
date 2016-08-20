// Copyright 2016.刘珅珅
// author：刘珅珅
// 序列化：XmlSerializer
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace serialize_test2
{
    public class Person
    {
        private string name;

        // 只读属性无法被Xml序列化
        public string Name
        {
            get { return name; }
        }

        // 序列化非基本类型的数组时，必须
        // 这样指明类型
        [XmlElement(Type = typeof(Course))]
       public Course[] course;

        public Person() { }
        public Person(string name)
        {
            this.name = name;
        }
    }

    public class Course
    {
        private string name;
        private string description;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Course() {}
        public Course(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }

    class SerializeTest
    {
        // XML序列化
        static void XMLSerialize()
        {
            Person p = new Person("cyj");
            p.course = new Course[2];
            p.course[0] = new Course("英语", "交流工具");
            p.course[1] = new Course("数学", "自然科学");

            XmlSerializer xs = new XmlSerializer(p.GetType());
            Stream stream = new FileStream("temp.xml", FileMode.Create, FileAccess.Write);
            xs.Serialize(stream, p);
            stream.Close();
        }

        // 反序列化
        static void XMLDeserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            Stream stream = new FileStream("temp.xml", FileMode.Open, FileAccess.Read);
            Person p = xs.Deserialize(stream) as Person;
            stream.Close();

            // 只读属性没有被序列化，反序列化时默认为null
            if (p.Name == null)
                Console.WriteLine("XML Deserialize Name is null");
            foreach (var c in p.course)
            { 
                Console.WriteLine("XML Deserialize course name" + c.Name);
                Console.WriteLine("XML Deserialize course description" + c.Description); 
            }
            
        }

        static void Main(string[] args)
        {
            XMLSerialize();
            XMLDeserialize();
        }
    }
}
