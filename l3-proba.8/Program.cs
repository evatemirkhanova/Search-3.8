using System;

class Program
{
    static void Main(string[] args)
    {
        // Приветствие и объяснение ввода данных
        Console.WriteLine("Для решения задачи о постройке юнитов введите следующие данные:");
        Console.WriteLine("1. Количество типов ресурсов (n):");

        // Ввод количества типов ресурсов
        int n = int.Parse(Console.ReadLine());

        // Массивы для хранения ...

        int[] a = new int[n]; // ...количества ресурсов для постройки одного юнита КАЖДОГО типа
        int[] b = new int[n]; // ...количества ресурсов, имеющееся у Пети
        int[] exchangeRate = new int[n]; // ...количества ресурсов, которое Петя получит за одну единицу золота для каждого типа ресурса
                                         // ( обменный курс для каждого типа ресурса )

        // Ввод количества ресурсов для постройки одного юнита каждого типа
        Console.WriteLine("2. Введите количество ресурсов для постройки одного юнита каждого типа (разделите каждое число Enter):");
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        // Ввод количества ресурсов, имеющегося у Пети
        Console.WriteLine("3. Введите количество ресурсов, имеющееся у Пети (разделите каждое число Enter):");
        for (int i = 0; i < n; i++)
        {
            b[i] = int.Parse(Console.ReadLine());
        }

        // Ввод обменного курса для каждого типа ресурса
        Console.WriteLine("4. Введите обменный курс для каждого типа ресурса (разделите каждое число Enter):");
        for (int i = 0; i < n; i++)
        {
            exchangeRate[i] = int.Parse(Console.ReadLine());
        }

        // Ввод количества золота у Пети
        Console.WriteLine("5. Введите количество золота у Пети:");
        int d = int.Parse(Console.ReadLine());

        // Вычисляем, сколько ресурсов каждого типа может получить Петя за свое золото
        int[] exchangedResources = new int[n];
        for (int i = 0; i < n; i++)
        {
            exchangedResources[i] = d * exchangeRate[i];
        }

        // Вычисляем минимальное количество юнитов, которое Петя может построить
        int minUnits = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            int units = (b[i] + exchangedResources[i]) / a[i];
            minUnits = Math.Min(minUnits, units);
        }

        // Выводим результат
        Console.WriteLine("Петя может построить " + minUnits + " юнитов.");
    }
}