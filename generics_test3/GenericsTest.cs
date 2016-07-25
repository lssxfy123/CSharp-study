// Copyright 2016.刘珅珅
// author：刘珅珅
// 泛型类型约束：接口约束
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_test3
{
    class NotFoundException : Exception
    {
        public NotFoundException() : base() { }
        public NotFoundException(string message) : base(message) { }
        public NotFoundException(string message, Exception inner)
            : base(message, inner) { }
        protected NotFoundException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    public interface IPhoneNumber
    {
        // 接口中的属性在语法上和自动实现属性类似，
        // 但有本质的不同，这是抽象的属性
        // 接口中的属性可以只有get或set
        // 自动实现属性必须具有get和set
        string Number
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }
    }

    class Friend : IPhoneNumber
    {
        public Friend(string n, string num, bool wk)
        {
            Name = n;
            Number = num;
            IsWorkNumber = wk;
        }

        public bool IsWorkNumber { get; private set; }

        public string Number { get; set; }
        public string Name { get; set; }
    }

    class EmailFriend { }

    class PhoneList<T> where T : IPhoneNumber
    {
        T[] list;
        int end;

        public PhoneList()
        {
            list = new T[10];
            end = 0;
        }

        public bool Add(T new_entry)
        {
            if (end == 10)
            {
                return false;
            }

            list[end] = new_entry;
            ++end;
            return true;
        }

        public T FindByName(string name)
        {
            for (int i = 0; i < end; ++i)
            {
                if (list[i].Name == name)
                {
                    return list[i];
                }
            }
            throw new NotFoundException();
        }

        public T FindByNumber(string number)
        {
            for (int i = 0; i < end; ++i)
            {
                if (list[i].Number == number)
                {
                    return list[i];
                }
            }
            throw new NotFoundException();
        }
    }

    class GenericsTest
    {
        static void Main(string[] args)
        {
            PhoneList<Friend> flist = new PhoneList<Friend>();
            flist.Add(new Friend("Tom", "555-1234", true));
            flist.Add(new Friend("Matt", "555-9527", false));

            try
            {
                Friend frnd = flist.FindByName("Tom");

                Console.WriteLine(frnd.Name + ": " + frnd.Number);

                Friend frnd1 = flist.FindByName("Gary");
                Console.WriteLine(frnd1.Name + ": " + frnd1.Number);
            } catch (NotFoundException)
            {
                Console.WriteLine("Not Found");
            }
            // error，EmailFriend没有继承IPhoneNumber
            // PhoneList<EmailFriend> elist = new PhoneList<EmailFriend>();
        }
    }
}
