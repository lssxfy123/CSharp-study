// Copyright 2016.刘珅珅
// author：刘珅珅
// 事件的应用
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_test5
{
    class KeyEventArgs : EventArgs
    {
        public char ch;
    }

    class KeyEvent
    {
        // public event EventHandler<KeyEventArgs> KeyPress;
        public  EventHandler<KeyEventArgs> KeyPress;

        public void OnKeyPress(char key)
        {
            KeyEventArgs k = new KeyEventArgs();

            if (KeyPress != null)
            {
                k.ch = key;
                KeyPress(this, k);
            }
        }
    }

    class EventTest
    {
        static void Main(string[] args)
        {
            KeyEvent kevt = new KeyEvent();
            ConsoleKeyInfo key;
            int count = 0;

            kevt.KeyPress += (sender, e) =>
                Console.WriteLine(" Received keystroke: " + e.ch);

            kevt.KeyPress += (sender, e) =>
                count++;

            Console.WriteLine("Enter some characters.");

            do
            {
                key = Console.ReadKey();
                kevt.OnKeyPress(key.KeyChar);
            } while (key.KeyChar != '.');

            Console.WriteLine(count + " keys press.");
        }
    }
}
