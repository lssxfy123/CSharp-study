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
        static void SaveJson(string path, string value)
        {
            FileStream FsJsonFile = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter SwJsonFile = new StreamWriter(FsJsonFile);
            SwJsonFile.WriteLine(value);
            SwJsonFile.Flush();
            SwJsonFile.Close();
            FsJsonFile.Close();
        }

        //public static string GetJsonValueByKey(string json, string key)
        //{
        //    string result = string.Empty;
           
        //    return result;
        //}

        public static JToken GetJsonValueByKey(JToken json, string key)
        {
            JToken result = null;
            if (json is JObject)
            {
                foreach (JProperty property in (json as JObject).Properties())
                {
                    if (property.Name == key)
                    {
                        result = (json as JObject).Property(key).Value;
                        break;
                    }
                    else
                    {
                        return GetJsonValueByKey((json as JObject).Property(property.Name).Value, key);
                    }
                }
            } else if (json is JArray)
            {
                foreach (JToken item in (json as JArray))
                {
                    if (item is JObject)
                    {
                        foreach (JProperty property in (item as JObject).Properties())
                        {
                            if (property.Name == key)
                            {
                                result = (item as JObject).Property(key).Value;
                                break;
                            }
                            else
                            {
                                return GetJsonValueByKey((item as JObject).Property(property.Name).Value, key);
                            }
                        }
                    }
                }
            }
 
            return result;
        }

        static void Main(string[] args)
        {
            string fileName = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.json");
            FileInfo fileInfo = new FileInfo(fileName);
            JToken result = null;
            using (StreamReader sr = fileInfo.OpenText())
            {
                string st = sr.ReadToEnd();
                result = (JToken)JsonConvert.DeserializeObject(st);
            }

            JToken value = GetJsonValueByKey(result, "dpubArr");

            if (value is JObject)
            {
                JObject obj = value as JObject;
                Console.WriteLine("object : " + obj.ToString());
            }
            else if (value is JArray)
            {
                JArray array = value as JArray;
                Console.WriteLine("array : " + array.ToString());
            }

            JToken value1 = GetJsonValueByKey(result, "9eff6a57-5699-42d3-bce0-1262147e6836");
            if (value1 is JObject)
            {
                JObject obj = value1 as JObject;
                Console.WriteLine("object : " + obj.ToString());
            } else if (value1 is JArray)
            {
                JArray array = value1 as JArray;
                Console.WriteLine("array : " + array.Count);
            }
        }
    }
}
