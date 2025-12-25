// Program.cs
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("🎯 ПРИВЕТ! CI/CD ПАЙПЛАЙН ЗАПУЩЕН И РАБОТАЕТ");
        Console.WriteLine($"Сейчас: {DateTime.Now}");
        
        int sum = Add(10, 20);
        Console.WriteLine($"10 + 20 = {sum}");
    }
    
    static int Add(int a, int b) => a + b;
}
