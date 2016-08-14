// Copyright 2016.刘珅珅
// author：刘珅珅
// 访问HTTP附加信息
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace internet_test4
{
    class HttpTest
    {
        static void Main(string[] args)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.McGraw-Hill.com");

                // 创建internet响应
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // 访问报头
                string[] names = response.Headers.AllKeys;

                Console.WriteLine("{0,-20}{1}\n", "Name", "Value");
                foreach (string name in names)
                {
                    Console.Write("{0,-20}", name);
                    foreach (string value in response.Headers.GetValues(name))
                        Console.WriteLine(value);
                }

                response.Close();
            }
            catch (WebException e)
            {
                Console.WriteLine("Network Error: " + e.Message + "\nStatus code: " + e.Status);
            }
            catch (ProtocolViolationException e)
            {
                Console.WriteLine("Protocol Error: " + e.Message);
            }
            catch (UriFormatException e)
            {
                Console.WriteLine("URI Format Error: " + e.Message);
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine("Unknown Protocol: " + e.Message);
            }
            catch (System.Security.SecurityException e)
            {
                Console.WriteLine("Security Exception: " + e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Invalid Operation: " + e.Message);
            }
        }
    }
}
