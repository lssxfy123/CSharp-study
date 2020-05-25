// 查看文件被哪些进程占用

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace file_process_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\shenshen\Desktop\test\test.doc";//要检查被那个进程占用的文件

            Process tool = new Process();
            tool.StartInfo.FileName = @"C:\Users\shenshen\Downloads\Handle\handle64.exe";
            tool.StartInfo.Arguments = fileName + " /accepteula";
            tool.StartInfo.UseShellExecute = false;
            tool.StartInfo.RedirectStandardOutput = true;
            tool.Start();
            tool.WaitForExit();
            string outputTool = tool.StandardOutput.ReadToEnd();

            string matchPattern = @"(?<=\s+pid:\s+)\b(\d+)\b(?=\s+)";
            foreach (Match match in Regex.Matches(outputTool, matchPattern))
            {
                Console.WriteLine(match.Value);
                //Process.GetProcessById(int.Parse(match.Value)).Kill();
            }
        }
    }
}
