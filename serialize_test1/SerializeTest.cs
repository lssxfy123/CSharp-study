// Copyright 2016.刘珅珅
// author：刘珅珅
// 序列化：BinaryFormatter
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace serialize_test1
{
    [Serializable]
    public class ClassToSerialize
    {
        private  int id;
        private string name;

        // 不对Sex字段进行序列化
        [NonSerialized]
        private string sex;

        public int ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Sex
        {
            get { return sex; }
        }

        public ClassToSerialize()
        {

        }

        public ClassToSerialize(int id, string name, string Sex)
        {
            this.id = id;
            this.name = name;
            this.sex = Sex;
        }

        public void Print()
        {
            Console.WriteLine("{0}", id);
        }
    }

    class SerializeTest
    {
        // 序列化
        static void SerializeNow()
        {
            ClassToSerialize obj = new ClassToSerialize(100, "Name", "男");
            FileStream stream = new FileStream("temp.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            stream.Close();
        }

        // 反序列化
        static void DeSerializeNow()
        {
            ClassToSerialize obj = new ClassToSerialize();
            FileStream stream = new FileStream("temp.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            obj = formatter.Deserialize(stream) as ClassToSerialize;
            stream.Close();

            Console.WriteLine("DeSerialize obj Name " + obj.Name);
            Console.WriteLine("DeSerialize obj ID " + obj.ID);
            obj.Print();

            // 未进行序列化的字段反序列化得到的值为null
            if (obj.Sex == null)
                Console.WriteLine("DeSerialize obj Sex is null");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start Serialize ");
            SerializeNow();

            Console.WriteLine("Start DeSerialize");
            DeSerializeNow();
        }
    }
}
