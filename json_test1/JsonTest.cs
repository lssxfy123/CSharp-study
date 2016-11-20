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
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            FileStream FsJsonFile = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter SwJsonFile = new StreamWriter(FsJsonFile);
            SwJsonFile.WriteLine(value);
            SwJsonFile.Flush();
            SwJsonFile.Close();
            FsJsonFile.Close();
        }

        static void Main(string[] args)
        {
            string fileName = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.json");

            JObject obj = new JObject(new JProperty("activityUserArr", new JArray(
                new JObject(new JProperty("durationType", 2), 
                new JProperty("duration", 716),
                new JProperty("timestamp", 147),
                new JProperty("updateTimestamp", 148)))));

            string json = JsonConvert.SerializeObject(obj);
            SaveJson(fileName, json);

            JObject obj1 = new JObject(new JProperty("durationType", 3),
                new JProperty("duration", 717),
                new JProperty("timestamp", 148),
                new JProperty("updateTimestamp", 149));

            FileInfo fileInfo = new FileInfo(fileName);
            JObject result;
            using (StreamReader sr = fileInfo.OpenText())
            {
                string st = sr.ReadToEnd();
                result = (JObject)JsonConvert.DeserializeObject(st);
            }

            JArray items = result["activityUserArr"] as JArray;
            if (items.Count > 0)
            {
                long time = Convert.ToInt64((items.Last["timestamp"]).ToString());
                Console.WriteLine(time);
            }
            items.Add(obj1);
            json = JsonConvert.SerializeObject(result);
            SaveJson(fileName, json);
            //JObject jObj = ;
        }
    }
}
