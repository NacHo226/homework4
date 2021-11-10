using System;
using System.Collections.Generic;

namespace task2
{
    public class task2
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(2);
            numbers.Enqueue(9);
            numbers.Enqueue(5);
            numbers.Enqueue(6);
            numbers.Enqueue(1);
            numbers.Enqueue(3);
            int max = int.MinValue;
            int min = int.MaxValue;
            int imax = 0;
            int imin = 0;
            int sum = 0;
            int[] array = new int[numbers.Count];
            numbers.CopyTo(array,0);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    imin = i;
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    imax = i;
                }
            }
            for (int i = imax; i < imin + 1; i++)
                sum = sum + array[i];
            Console.WriteLine("min = {0}, max={1}, sum={2} ", min, max, sum);
        }
    }
}