// Copyright 2016.刘珅珅
// author：刘珅珅
// WebClient下载数据
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace internet_test5
{
    class WebClientTest
    {
        static void Main(string[] args)
        {
            WebClient user = new WebClient();
            string uri = "http://www.163.com";

            string file_name = "data.txt";

            try
            {
                Console.WriteLine("Downloading data from " + uri + " to " + file_name);
                user.DownloadFile(uri, file_name);
            } catch (WebException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Download complete");
        }
    }
}
