// Copyright 2016.刘珅珅
// author：刘珅珅
// socket套接字操作
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace socket_test1
{
    class SocketTest
    {
        static void Main(string[] args)
        {
            IP = IPAddress.Parse("192.168.1.54");
            Port = 8081;
            SendFile("", LoginFileName);

            while (true)
            {
                Thread.Sleep(1000);
            }
        }

        private static readonly string _ActivityPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserActivity");
        public const string SendHead = "#begin";
        public const string Separtor = "@";
        public const string LoginFileName = "activityUser.log";
        public const string ActivityUserArrKey = "activityUserArr";
        public const string DurationTypeKey = "durationType";
        public const string DurationKey = "duration";
        public const string TimeStampKey = "timestamp";
        public const string UpdateTimeStampKey = "updateTimestamp";

        // 用户信息
        public static string HeadInfo { get; set; }

        // IP地址
        public static IPAddress IP { get; set; }

        // 端口
        public static int Port { get; set; }

        public enum DurationType
        {
            Launching = 0,  // 登陆
            ResingActive = 1,  // 后台
            BecomeActive = 2,  // 重新激活
            Terminate = 3  // 退出
        };

        private static bool Receive(Socket client)
        {
            // Begin receiving the data from the remote device.
            //定义发送数据缓存
            byte[] data = new byte[1024];
            //定义接收数据的长度
            int recv = client.Receive(data);

            //将接收的数据转换成字符串
            string stringData = Encoding.UTF8.GetString(data, 0, recv);
            if (stringData.Contains("status=success"))
            {
                return true;
            }

            return false;
        }

        // 资源记录
        public static void SendFile(string userId, string name)
        {
            string fileName = System.IO.Path.Combine(_ActivityPath, name);
            if (File.Exists(fileName))
                ThreadPool.QueueUserWorkItem(so =>
                {
                    IPEndPoint remoteEP = new IPEndPoint(IP, Port);
                    Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        client.Connect(remoteEP);
                    }
                    catch (Exception e)
                    {
                        return;
                    }

                    if (client.Connected)
                    {
                        try
                        {
                            string content = File.ReadAllText(fileName);
                            byte[] byteData = Encoding.UTF8.GetBytes(content);
                            client.Send(byteData, 0, byteData.Length, 0);

                            bool _callback = Receive(client);
                            if (_callback)
                            {
                                File.Delete(fileName);
                            }

                            client.Shutdown(SocketShutdown.Both);
                            client.Close();
                        }
                        catch (Exception e)
                        {
                            return;
                        }

                    }
                }, null);
        }

    }
}
