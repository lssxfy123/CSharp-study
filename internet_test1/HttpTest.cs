// Copyright 2016.刘珅珅
// author：刘珅珅
// HTTP协议
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace internet_test1
{
    class HttpTest
    {
        static void Main(string[] args)
        {
            // 创建internet请求
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.163.com");

            // 创建internet响应
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // 从响应中提取输入
            Stream stream = response.GetResponseStream();

            for (int i = 1; ; ++i)
            {
                int ch = stream.ReadByte();
                if (ch == -1) break;

                Console.Write((char) ch);

                if ((i % 400) == 0)
                {
                    Console.Write("\nPress Enter.");
                    Console.ReadLine();
                }
            }

            response.Close();
        }
    }
}
