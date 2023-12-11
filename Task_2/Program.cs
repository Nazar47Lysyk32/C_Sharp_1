using System;

class Program
{
    static void Main()
    {
        // Оголошуємо змінні для суми, максимуму, мінімуму та добутку
        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;
        int product = 1;

        // Користувач вводить п'ять чисел
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter a number {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                // Обчислюємо суму, максимум, мінімум та добуток
                sum += number;
                if (number > max)
                    max = number;
                if (number < min)
                    min = number;
                product *= number;
            }
            else
            {
                Console.WriteLine("Incorrect input. Please enter an integer.");
                i--; // Повторюємо введення для цього числа
            }
        }

        // Виводимо результати обчислень на екран
        Console.WriteLine($"\nSum: {sum}");
        Console.WriteLine($"Maximum: {max}");
        Console.WriteLine($"Minimum: {min}");
        Console.WriteLine($"Product: {product}");
    }
}
