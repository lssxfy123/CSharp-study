// Copyright 2016.刘珅珅
// author：刘珅珅
// json的处理
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace json_test1
{
    class JsonTest
    {
        static void Main(string[] args)
        {
            //string fileName = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.json");
            //FileInfo fileInfo = new FileInfo(fileName);
            //JToken result = null;
            //using (StreamReader sr = fileInfo.OpenText())
            //{
            //    string st = sr.ReadToEnd();
            //    result = (JToken)JsonConvert.DeserializeObject(st);
            //}
            JObject obj = new JObject(
                new JProperty("time", 1),
                new JProperty("add", new JObject())
                );
            string content = JsonConvert.SerializeObject(obj);
            Console.WriteLine(content);

            JObject addObject = obj.Property("add").Value as JObject;
            addObject.Add(new JProperty("behavior", 0));
            content = JsonConvert.SerializeObject(obj);
            Console.WriteLine(content);
        }
    }
}
