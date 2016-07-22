// Copyright 2016.刘珅珅
// author：刘珅珅
// I/O文件读写操作
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace io_test3
{
    class IOTest
    {
        static void Main(string[] args)
        {
            FileStream fin;
            string s;

            try
            {
                fin = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error opening file: " + ex.Message);
                return;
            }

            StreamReader fstr_in = new StreamReader(fin);

            try
            {
                while (!fstr_in.EndOfStream)
                {
                    s = fstr_in.ReadLine();
                    Console.WriteLine(s);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
            finally
            {
                fstr_in.Close();
            }
            fin.Close();
        }
    }
}
