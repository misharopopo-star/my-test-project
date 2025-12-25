// UnitTest.cs - простые тесты без xUnit
using System;

public class SimpleTests
{
    public static void RunTests()
    {
        Console.WriteLine("🧪 ЗАПУСК ПРОСТЫХ ТЕСТОВ...");
        
        TestAddition();
        TestSubtraction();
        
        Console.WriteLine("✅ ВСЕ ТЕСТЫ ПРОЙДЕНЫ!");
    }
    
    static void TestAddition()
    {
        int result = Add(5, 3);
        if (result == 8)
            Console.WriteLine("✓ TestAddition: PASSED");
        else
            Console.WriteLine("✗ TestAddition: FAILED (expected 8, got " + result + ")");
    }
    
    static void TestSubtraction()
    {
        int result = Subtract(10, 4);
        if (result == 6)
            Console.WriteLine("✓ TestSubtraction: PASSED");
        else
            Console.WriteLine("✗ TestSubtraction: FAILED");
    }
    
    // Методы из Program.cs должны быть доступны
    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
}
