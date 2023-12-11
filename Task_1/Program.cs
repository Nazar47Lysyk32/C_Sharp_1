using System;

class Program
{
    static void Main()
    {
        // Створюємо масив цілих чисел розміром 5 елементів
        int[] array = new int[5];

        // Заповнюємо масив значеннями, введеними користувачем
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Enter a value for the element {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                array[i] = value;
            }
            else
            {
                Console.WriteLine("Incorrect input. Please enter an integer.");
                i--; // Повторюємо введення для цього елемента
            }
        }

        // Виводимо вміст масиву на екран
        Console.WriteLine("Array contents:");
        foreach (int element in array)
        {
            Console.Write($"{element} ");
        }

        // Знаходимо та виводимо максимальний та мінімальний елементи масиву
        int max = array[0];
        int min = array[0];

        foreach (int element in array)
        {
            if (element > max)
            {
                max = element;
            }

            if (element < min)
            {
                min = element;
            }
        }

        Console.WriteLine($"\nMaximum element: {max}");
        Console.WriteLine($"Minimal element: {min}");
    }
}
