// Program.cs
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("🎯 ПРИВЕТ! CI/CD РАБОТАЕТ!");
        Console.WriteLine($"Сейчас: {DateTime.Now}");
        
        // Запуск тестов
        SimpleTests.RunTests();
        
        // Основная логика
        int sum = Add(10, 20);
        Console.WriteLine($"10 + 20 = {sum}");
    }
    
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
}
