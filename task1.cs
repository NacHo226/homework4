using System;
using System.Collections.Generic;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            a.Add(1);
            a.Add(15);
            a.Add(45);
            a.Add(7);
            a.Add(8);
            a.Add(22);
            a.Add(73);
            a.Add(10);
            HashSet<int> b = new HashSet<int>
            {
                7,
                8,
                42,
                22,
                12
            };
            a.IntersectWith(b);//заменяем множество а на множество состоящее из элементов которые находятся в двух множествах одновременно
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
