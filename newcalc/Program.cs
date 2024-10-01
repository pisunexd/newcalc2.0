
{
    
    {
        Console.Write("Первое число: ");
        double a1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Операция (+, -, *, /, Max, Min, Abs, Ceiling, Floor, Sqrt, P, A, C, S): ");
        Console.WriteLine();

        double a2 = 0;
        string operation = Console.ReadLine();
        if (operation != "Abs" && operation != "Ceiling" && operation != "Floor" && operation != "Sqrt")
        {
            Console.Write("Второе число (если требуется): ");
            a2 = Convert.ToDouble(Console.ReadLine());
        }

        Calculator calc = new();
        double result = 0;

        switch (operation)
        {
            case "+":
                result = calc.Add(a1, a2);
                Console.WriteLine($"Результат: {result}");
                break;
            case "-":
                result = calc.Subtract(a1, a2);
                Console.WriteLine($"Результат: {result}");
                break;
            case "*":
                result = calc.Multiply(a1, a2);
                Console.WriteLine($"Результат: {result}");
                break;
            case "/":
                if (a2 != 0)
                {
                    result = calc.Divide(a1, a2);
                    Console.WriteLine($"Результат: {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль.");
                }
                break;
            case "Max": // максимальное число между числами
                result = calc.Max(a1, a2);
                Console.WriteLine($"Максимум: {result}");
                break;
            case "Min": // минимальное число между числами
                result = calc.Min(a1, a2);
                Console.WriteLine($"Минимум: {result}");
                break;
            case "Abs": // absolute? akashi?
                result = calc.Abs(a1);
                Console.WriteLine($"Абсолютное значение: {result}");
                break;
            case "Ceiling": // Округляет число до большего целого
                result = calc.Ceiling(a1);
                Console.WriteLine($"Округление вверх: {result}");
                break;
            case "Floor": // Округляет число до меньшего целого
                result = calc.Floor(a1);
                Console.WriteLine($"Округление вниз: {result}");
                break;
            case "Sqrt": // Квадратный корень
                result = calc.Sqrt(a1);
                Console.WriteLine($"Квадратный корень: {result}");
                break;
            case "P": // Периметр квадрата
                result = calc.CalculateSquarePerimeter(a1);
                Console.WriteLine($"Периметр квадрата: {result}");
                break;
            case "A": // Площадь круга
                result = calc.CalculateCircleArea(a1);
                Console.WriteLine($"Площадь круга: {result}");
                break;
            case "C": // Окружность круга
                result = calc.CalculateCircleCircumference(a1);
                Console.WriteLine($"Окружность круга: {result}");
                break;
            case "S": // Площадь прямоугольника
                result = calc.CalculateRectangleArea(a1, a2);
                Console.WriteLine($"Площадь прямоугольника: {result}");
                break;
            default:
                Console.WriteLine("Неверная операция.");
                break;
        }
    }
}

class Calculator
{
    // Арифметические операции
    public double Add(double a, double b) => a + b;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;
    public double Divide(double a, double b) => a / b;

    // Логические операции через Math
    public double Max(double a, double b) => Math.Max(a, b);
    public double Min(double a, double b) => Math.Min(a, b);
    public double Abs(double a) => Math.Abs(a);
    public double Ceiling(double a) => Math.Ceiling(a);
    public double Floor(double a) => Math.Floor(a);
    public double Sqrt(double a) => Math.Sqrt(a);

    // Геометрические операции
    public double CalculateSquarePerimeter(double side) => 4 * side;
    public double CalculateCircleArea(double radius) => Math.PI * radius * radius;
    public double CalculateCircleCircumference(double radius) => 2 * Math.PI * radius;
    public double CalculateRectangleArea(double length, double width) => length * width;
}