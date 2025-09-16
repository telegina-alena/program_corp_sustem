using System;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double memory = 0;
            string value; 
            do
            {
                double res;
                Console.Write("Введите символ (/, +, -, *, %, 1/x, x**2, sqrt(x), M+, M-, MR: ");
                string symbol = Console.ReadLine();
                if (symbol == "/" || symbol == "+" || symbol == "-" || symbol == "*" || symbol == "%")
                {
                    Console.Write("Введите первое число: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    switch (symbol)
                    {
                        case "+":
                            res = num1 + num2;
                            Console.WriteLine("Результат суммы: " + res);
                            memory = res;
                            break;
                        case "-":
                            res = num1 - num2;
                            Console.WriteLine("Результат разности: " + res);
                            memory = res;
                            break;
                        case "*":
                            res = num1 * num2;
                            Console.WriteLine("Результат умножения: " + res);
                            memory = res;
                            break;
                        case "/":
                            if (num2 != 0)
                            {
                                res = num1 / num2;
                                Console.WriteLine("Результат деления: " + res);
                                memory = res;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: Деление на ноль.");
                            }
                            break;
                        case "%":
                            res = num1 % num2;
                            Console.WriteLine("Остаток от деления: " + res);
                            memory = res;
                            break;
                        default:
                            Console.WriteLine("Неверный формат ввода числа.");
                            break;
                    }
                }
                else if (symbol == "1/x" || symbol == "x**2" || symbol == "sqrt(x)" || symbol == "M+" || symbol == "M-")
                {
                    Console.Write("Введите число: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    switch (symbol)
                    {
                        case "1/x":
                            if (num == 0)
                            {
                                Console.WriteLine("Ошибка: Деление на ноль запрещено.");
                            }
                            else
                            {
                                res = 1.0 / num;
                                Console.WriteLine("Результат деления первого числа 1 / x: " + res);
                                memory = res;
                            }
                            break;
                        case "x**2":
                            res = Math.Pow(num, 2);
                            Console.WriteLine("Результат возведения в квадраn числа: " + res);
                            memory = res;
                            break;
                        case "sqrt(x)":
                            if (num < 0)
                            {
                                Console.WriteLine("Ошибка. Из отрицательного числа нельзя вычислить корень");
                            }
                            else
                            {
                                res = Math.Sqrt(num);
                                memory = res;
                                Console.WriteLine("Результат вычисления квадратного корня из первого числа: " + res);

                            }
                            break;
                        case "M+":
                            memory += num;
                            Console.WriteLine("Сумма числа из памяти и введенного числа: " + memory);
                            break;
                        case "M-":
                            memory -= num;
                            Console.WriteLine("Вычитание введенного числа из числа с памяти: " + memory);
                            break;
                        default:
                            Console.WriteLine("Неверный формат ввода числа.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Значение в памяти:" + memory);
                }
                    Console.ReadLine();
                    Console.Write("Хотите продолжить вычисления? (y/n): ");
                    value = Console.ReadLine();
                }
        while (value == "y" || value == "Y");
        }
    }
}