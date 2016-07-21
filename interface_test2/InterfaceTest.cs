// Copyright 2016.刘珅珅
// author：刘珅珅
// 接口类型的引用
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_test2
{
    public interface ISeries
    {
        int GetNext();
        void Reset();
        void SetStart(int x);
    }

    class ByTwos : ISeries
    {
        int start;
        int val;

        public ByTwos()
        {
            start = 0;
            val = 0;
        }

        public int GetNext()
        {
            val += 2;
            Console.WriteLine("ByTwos Next value " + val);
            return val;
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }

    class Primes : ISeries
    {
        int start;
        int val;

        public Primes()
        {
            start = 2;
            val = 2;
        }

        public int GetNext()
        {
            val += 1;
            Console.WriteLine("Primes Next value " + val);
            return val;
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }

    class InterfaceTest
    {
        static void Main(string[] args)
        {
            ByTwos two_obj = new ByTwos();
            Primes prime_obj = new Primes();
            ISeries interface_obj;

            interface_obj = two_obj;
            interface_obj.GetNext();

            interface_obj = prime_obj;
            interface_obj.GetNext();
        }
    }
}
