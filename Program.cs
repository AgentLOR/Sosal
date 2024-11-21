using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в калькулятор!");

    start: // Метка для возврата
        Console.WriteLine("\nВыберите действие:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        Console.WriteLine("5. Остаток от деления");
        Console.WriteLine("6. Возведение в степень");
        Console.WriteLine("7. Квадратный корень");
        Console.WriteLine("8. Площадь круга");
        Console.WriteLine("9. Площадь квадрата");
        Console.WriteLine("10. Площадь прямоугольника");
        Console.WriteLine("11. Площадь треугольника");
        Console.WriteLine("12. Объем куба");
        Console.WriteLine("13. Выход");

        Console.Write("Введите номер операции (1-13): ");
        int operation = Convert.ToInt32(Console.ReadLine());

        double number1 = 0;
        double number2 = 0;

        if (operation >= 1 && operation <= 10) // Для числовых операций
        {
            Console.Write("Введите первое число: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            if (operation != 7) // Для вычисления площади прямоугольника и треугольника
            {
                Console.Write("Введите второе число: ");
                number2 = Convert.ToDouble(Console.ReadLine());
            }
        }

        double result = 0;

        switch (operation)
        {
            case 1: // Сложение
                result = number1 + number2;
                Console.WriteLine($"Результат: {result}");
                break;
            case 2: // Вычитание
                result = number1 - number2;
                Console.WriteLine($"Результат: {result}");
                break;
            case 3: // Умножение
                result = number1 * number2;
                Console.WriteLine($"Результат: {result}");
                break;
            case 4: // Деление
                if (number2 != 0)
                {
                    result = number1 / number2;
                    Console.WriteLine($"Результат: {result}");
                }
                else
                {
                    Console.WriteLine("ну ты конечно не ANDERGRAUND");
                }
                break;
            case 5: // Остаток от деления
                result = number1 % number2;
                Console.WriteLine($"Результат: {result}");
                break;
            case 6: // Возведение в степень
                result = Math.Pow(number1, number2);
                Console.WriteLine($"Результат: {result}");
                break;
            case 7: // Квадратный корень
                if (number1 >= 0)
                {
                    result = Math.Sqrt(number1);
                    Console.WriteLine($"Результат: {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Невозможно извлечь квадратный корень из отрицательного числа!");
                }
                break;
            case 8: // Площадь круга
                result = Math.PI * Math.Pow(number1, 2); // number1 - это радиус круга
                Console.WriteLine($"Площадь круга: {result}");
                break;

            case 9: // Площадь квадрата
                result = Math.Pow(number1, 2); // number1 - это сторона квадрата
                Console.WriteLine($"Площадь квадрата: {result}");
                break;
            case 10: // Площадь прямоугольника
                result = number1 * number2; // number1 и number2 - это стороны прямоугольника
                Console.WriteLine($"Площадь прямоугольника: {result}");
                break;
            case 11: // Площадь треугольника
                result = 0.5 * number1 * number2; // number1 и number2 - это основание и высота
                Console.WriteLine($"Площадь треугольника: {result}");
                break;
            case 12: // Объем куба
                result = Math.Pow(number1, 3); // number1 - это сторона куба
                Console.WriteLine($"Объем куба: {result}");
                break;
            case 13: // Выход
                Console.WriteLine("Выход из программы.");
                return; // Завершить программу
            default:
                Console.WriteLine("Ошибка: Неверный номер операции!");
                break;
        }

        // Вернуться к началу для следующей операции
        goto start;
    }
}
