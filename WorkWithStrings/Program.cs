using System;

class Program
{
    static void Main(string[] args) {
        string name;
        int age;
        string zodiakSign;
        int weight;

        Console.Write("Вас зовут: ");
        name = Console.ReadLine();

        Console.Write("Ваш возраст: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ваш знак зодиака: ");
        zodiakSign = Console.ReadLine();

        Console.Write("Ваш вес: ");
        weight = Convert.ToInt32(Console.ReadLine());
        Console.Write('\n');

        Console.WriteLine($"Вас зовут {name}, ваш возраст {age}, ваш знак зодиака {zodiakSign}, ваш вес {weight}");
    }
}
