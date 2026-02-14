using System;
class Programm
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("ОПЕРАЦИИ:");
            Console.WriteLine("1. Вычисление площади.");
            Console.WriteLine("2. Вычисление средней линии.");
            Console.WriteLine("3. Вычисление периметра равнобедренной трапеции.");
            Console.WriteLine("4. Выход из программы.");
            Console.Write("Выберите номер операции (1..4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CalculateArea();
                    break;
                case "2":
                    CalculateMiddleLine();
                    break;
                case "3":
                    CalculatePerimeter();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный выбор! Нажмите любую клавишу..");
                    Pause();
                    break;
            }
        }
    }

    // Ввод с проверкой
    static double ReadPositiveDouble(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (double.TryParse(input, out double value))
            {
                if (value > 0)
                    return value;
                else
                    Console.WriteLine("Ошибка! Число должно быть положительным.");
            }
            else
            {
                Console.WriteLine("Ошибка! Введите корректное число.");
            }
        }
    }

    // Задача 1. Площадь
    static void CalculateArea()
    {
        Console.Clear();
        Console.WriteLine("Вычисление площади трапеции\n");

        double baseA = ReadPositiveDouble("Введите основание a: ");
        double baseB = ReadPositiveDouble("Введите основание b: ");
        double height = ReadPositiveDouble("Введите высоту h: ");

        double area = ((baseA + baseB) * height) / 2;

        Console.WriteLine($"\nПлощадь трапеции: {area:F2}");
        Pause();
    }

    // Задача 2. Средняя линия
    static void CalculateMiddleLine()
    {
        Console.Clear();
        Console.WriteLine("Вычисление средней линии трапеции\n");

        double baseA = ReadPositiveDouble("Введите основание a: ");
        double baseB = ReadPositiveDouble("Введите основание b: ");

        double middleLine = (baseA + baseB) / 2;

        Console.WriteLine($"\nСредняя линия трапеции: {middleLine:F2}");
        Pause();
    }

    // Задача 3. Периметр
    static void CalculatePerimeter()
    {
        Console.Clear();
        Console.WriteLine("Вычисление периметра равнобедренной трапеции\n");

        double baseA = ReadPositiveDouble("Введите основание a: ");
        double baseB = ReadPositiveDouble("Введите основание b: ");
        double height = ReadPositiveDouble("Введите высоту h: ");

        double sideC = Math.Sqrt(Math.Pow(height, 2) + Math.Pow((baseA - baseB) / 2, 2));
        double perimetr = baseA + baseB + (2 * sideC);

        Console.WriteLine($"\nПериметр равнобедренной трапеции: {perimetr:F2}");
        Pause();
    }

    // Пауза 
    static void Pause()
    {
        Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
        Console.ReadKey();
    }
}
