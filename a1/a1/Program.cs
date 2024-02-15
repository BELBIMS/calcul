using System;

class Calculator<T>
{
    // Метод для сложения двух чисел
    public static T Add(T x, T y)
    {
        dynamic dx = x;
        dynamic dy = y;
        return dx + dy;
    }

    // Метод для вычитания одного числа из другого
    public static T Subtract(T x, T y)
    {
        dynamic dx = x;
        dynamic dy = y;
        return dx - dy;
    }

    // Метод для умножения двух чисел
    public static T Multiply(T x, T y)
    {
        dynamic dx = x;
        dynamic dy = y;
        return dx * dy;
    }

    // Метод для деления одного числа на другое
    public static T Divide(T x, T y)
    {
        dynamic dx = x;
        dynamic dy = y;
        if (dy == 0)
        {
            return (T)(object)"Ошибка: деление на ноль";
        }
        return dx / dy;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:"); // Ввод первого числа
        dynamic num1 = Convert.ChangeType(Console.ReadLine(), typeof(double));
        Console.WriteLine("Введите второе число:"); // Ввод второго числа
        dynamic num2 = Convert.ChangeType(Console.ReadLine(), typeof(double));

        Console.WriteLine("Выберите операцию:"); // Ввод операции
        char operation = char.Parse(Console.ReadLine());

        dynamic result = 0;
        switch (operation)
        {
            case '+':
                result = Calculator<dynamic>.Add(num1, num2); // Выполнение сложения
                break;
            case '-':
                result = Calculator<dynamic>.Subtract(num1, num2); // Выполнение вычитания
                break;
            case '*':
                result = Calculator<dynamic>.Multiply(num1, num2); // Выполнение умножения
                break;
            case '/':
                result = Calculator<dynamic>.Divide(num1, num2); // Выполнение деления
                break;
            default:
                Console.WriteLine("Неверная операция");
                break;
        }

        Console.WriteLine("Результат вычислений: " + result); // Вывод результата вычислений
    }
}
