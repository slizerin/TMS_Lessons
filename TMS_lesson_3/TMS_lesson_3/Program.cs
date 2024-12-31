namespace TMS_lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите первое число");
            var valid1 = decimal.TryParse(Console.ReadLine(), out var num1);
            if(valid1 is false)
            {
                Console.WriteLine("Вы ввели недопустимое значение ");
                return;
            }

            Console.WriteLine("Ведите второе число");
            var valid2 = decimal.TryParse(Console.ReadLine(), out var num2);
            if (valid2 is false)
            {
                Console.WriteLine("Вы ввели недопустимое значение ");
                return;
            }

            Console.WriteLine("Введите операцию: +, -, *, /, %");
            var op = Console.ReadLine();
            object res;
            switch(op)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {res}");
                    break;

                case "-":
                    res = num2 - num1;
                    Console.WriteLine($"{num1} - {num2} = {res}");
                    break;
                case "*":
                    res = num2 * num1;
                    Console.WriteLine($"{num1} * {num2} = {res}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Деление на 0 невозможно");
                    }
                    else
                    {
                        res = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {res}");
                    }
                    break;
                case "%":
                    {
                        res = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {res}");
                    }
                    break ;
                default:
                    Console.WriteLine("Введена некорректная операция");
                    Console.ReadKey();
                    break;
            }
            Console.ReadKey();
        }
    }
}
