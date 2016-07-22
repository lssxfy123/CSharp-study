// Copyright 2016.刘珅珅
// author：刘珅珅
// I/O操作：二进制读写
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace io_test4
{
    class IOTest
    {
        static void Main(string[] args)
        {
            BinaryWriter dataOut;
            BinaryReader dataIn;

            int i = 0;
            double d = 1023.56;
            bool b = true;
            string str = "This is a test";

            // Write
            try
            {
                dataOut = new BinaryWriter(new FileStream("testdata", FileMode.Create));
            } catch (IOException ex)
            {
                Console.WriteLine("Error opening file: " + ex.Message);
                return;
            }

            try
            {
                Console.WriteLine("Writing " + i);
                dataOut.Write(i);

                Console.WriteLine("Writing " + d);
                dataOut.Write(d);

                Console.WriteLine("Writing " + b);
                dataOut.Write(b);

                Console.WriteLine("Writing " + str);
                dataOut.Write(str);
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
            finally
            {
                dataOut.Close();
            }

            Console.WriteLine();

            // Read
            try
            {
                dataIn = new BinaryReader(new FileStream("testdata", FileMode.Open, FileAccess.Read));
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error opening file: " + ex.Message);
                return;
            }

            try
            {
                Console.WriteLine("Reading " + dataIn.ReadInt32());
                Console.WriteLine("Reading " + dataIn.ReadDouble());
                Console.WriteLine("Reading " + dataIn.ReadBoolean());
                Console.WriteLine("Reading " + dataIn.ReadString());
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
            finally
            {
                dataIn.Close();
            }
        }
    }
}
