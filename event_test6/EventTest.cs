// Copyright 2016.刘珅珅
// author：刘珅珅
// 事件与委托
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_test6
{
    // 定义事件引发时，传递的参数
    class NewMailEventArgs : EventArgs
    {
        private readonly string from;
        private readonly string to;
        private readonly string subject;

        public NewMailEventArgs(string from, string to, string subject)
        {
            this.from = from;
            this.to = to;
            this.subject = subject;
        }

        public string From
        {
            get { return from; }
        }

        public string To
        {
            get { return to; }
        }

        public string Subject
        {
            get { return subject; }
        }
    }

    // 事件所用的委托
    delegate void NewMailEventHandler(object sender, NewMailEventArgs e);
    // 提供事件的类
    // 在Observer模式中，相当于主题类
    class MailManager
    {
        public event NewMailEventHandler NewMail;

        // 通知已订阅事件的对象
        protected virtual void OnNewMail(NewMailEventArgs e)
        {
            if (NewMail != null)
                NewMail(this, e);
        }

        // 引发事件
        public void SimulateNewMail(string from, string to, string subject)
        {
            NewMailEventArgs e = new NewMailEventArgs(from, to, subject);
            OnNewMail(e);
        }
    }

    // 使用事件的类
    // 在Observer模式中相当于观察者类
    class Fax
    {
        public Fax(MailManager m)
        {
            m.NewMail += FaxNewMail;
        }

        private void FaxNewMail(object sender, NewMailEventArgs e)
        {
            Console.WriteLine("Message arrived at Fax...");
            Console.WriteLine("From = {0}, To = {1}, Subject = '{2}' ", e.From, e.To, e.Subject);
        }
    }

    // 另一个使用事件的类
    class Print
    {
        public Print(MailManager m)
        {
            m.NewMail += PrintNewMail;
        }

        private void PrintNewMail(object sender, NewMailEventArgs e)
        {
            Console.WriteLine("Message arrived at Print...");
            Console.WriteLine("From = {0}, To = {1}, Subject = {2}", e.From, e.To, e.Subject);
        }
    }

    class EventTest
    {
        static void Main(string[] args)
        {
            MailManager m = new MailManager();

            Fax fax = new Fax(m);
            Print prt = new Print(m);

            // 触发事件
            m.SimulateNewMail("Anco", "Jerry", "Event Test");
        }
    }
}
