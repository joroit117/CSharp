using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            string operator1 = Console.ReadLine();

            switch(operator1)
            {
                case "+":
                    if((number1 + number2) % 2 == 0)
                    {
                        Console.WriteLine($"{number1} + {number2} = {number1 + number2} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} + {number2} = {number1 + number2} - odd");
                    }
                    break;
                case "-":
                    if ((number1 - number2) % 2 == 0)
                    {
                        Console.WriteLine($"{number1} - {number2} = {number1 - number2} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} - {number2} = {number1 - number2} - odd");
                    }
                    break;
                case "*":
                    if ((number1 * number2) % 2 == 0)
                    {
                        Console.WriteLine($"{number1} * {number2} = {number1 * number2} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} * {number2} = {number1 * number2} - odd");
                    }
                    break;
                case "/":
                    if(number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} / {number2} = {number1 / number2:f2}");
                    }
                    break;
                case "%":
                    if (number2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {number1} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} % {number2} = {number1 % number2}");
                    }
                    break;
            }
        }
    }
}
