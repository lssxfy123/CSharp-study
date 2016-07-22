// Copyright 2016.刘珅珅
// author：刘珅珅
// IO操作：文件操作
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace io_test2
{
    class IOTest
    {
        static void Main(string[] args)
        {
            string str;
            FileStream fout;

            try
            {
                fout = new FileStream("test.txt", FileMode.Append);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error opening file: " + ex.Message);
                return;
            }

            StreamWriter fstr_out = new StreamWriter(fout);

            try
            {
                Console.WriteLine("Enter text: ");
                str = Console.ReadLine();
                fstr_out.WriteLine(str);
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
            finally
            {
                fstr_out.Close();
            }

            fout.Close();
        }
    }
}
