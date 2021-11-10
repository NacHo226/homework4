using System;
using System.Collections.Generic;
 
namespace task3
{
    class Program
    {
        private static List<int> krug = new(); // Список для номеров участников
        static void Main(string[] args)
        {
            Console.Write("Введите количество человек: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                krug.Add(i + 1); // Заполняем список
            }
            int current = 0; // Начинаем с первого
            while (krug.Count > 1)
            {
                current++;
                if (current >= krug.Count) current = 0; // Если пересекли границу, снова начинаем с первого
                krug.RemoveAt(current);
                if (current >= krug.Count) current = 0; // Если удаляли последний элемент, возвращаемся к первому
            }
            Console.WriteLine($"Остался человек № {krug[0]}");
            Console.ReadLine();
        }
    }
}