using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace process_test1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.FileName = "WindowsTest.exe";
            info.WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized;

            try
            {
                System.Diagnostics.Process.Start(info);
            }
            catch (Exception e)
            {
                
            }

            while (true)
            {
                Thread.Sleep(500);
            }
        }
    }
}
