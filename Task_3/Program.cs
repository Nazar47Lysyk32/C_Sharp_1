using System;

class Person
{
    // Властивість для імені
    public string Name { get; set; }

    // Властивість для віку
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            // Забороняємо встановлення віку менше 0
            if (value >= 0)
                age = value;
            else
                Console.WriteLine("Incorrect age value. Age cannot be negative.");
        }
    }

    // Метод для виведення інформації на екран
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        // Створюємо об'єкт класу Person
        Person person = new Person();

        // Встановлюємо ім'я та вік через властивості
        person.Name = "John";
        person.Age = 30;

        // Виводимо інформацію на екран
        person.DisplayInfo();

        // Змінюємо вік та виводимо оновлену інформацію на екран
        person.Age = 25;
        person.DisplayInfo();
    }
}
