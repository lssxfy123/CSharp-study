// Copyright 2016.刘珅珅
// author：刘珅珅
// 处理internet异常
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace internet_test2
{
    class HttpTest
    {
        static void Main(string[] args)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.McGraw-Hill.com/moon");

                // 创建internet响应
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // 从响应中提取输入
                Stream stream = response.GetResponseStream();

                for (int i = 1; ; ++i)
                {
                    int ch = stream.ReadByte();
                    if (ch == -1) break;

                    Console.Write((char)ch);

                    if ((i % 400) == 0)
                    {
                        Console.Write("\nPress Enter.");
                        Console.ReadLine();
                    }
                }

                response.Close();
            } catch (WebException e)
            {
                Console.WriteLine("Network Error: " + e.Message + "\nStatus code: " + e.Status);
            } catch (ProtocolViolationException e)
            {
                Console.WriteLine("Protocol Error: " + e.Message);
            } catch (UriFormatException e)
            {
                Console.WriteLine("URI Format Error: " + e.Message);
            } catch (NotSupportedException e)
            {
                Console.WriteLine("Unknown Protocol: " + e.Message);
            } catch (IOException e)
            {
                Console.WriteLine("I/O Error: " + e.Message);
            } catch (System.Security.SecurityException e)
            {
                Console.WriteLine("Security Exception: " + e.Message);
            } catch (InvalidOperationException e)
            {
                Console.WriteLine("Invalid Operation: " + e.Message);
            }
  
        }
    }
}
