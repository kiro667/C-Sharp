using System;

namespace Simple_Calculator__re6eni_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var values = input.Split(" ");

            var calculatorStack = new Stack<string>(values.Reverse());


            while (calculatorStack.Count > 1)
            {//poneje e while cikuyl gi po4vam otzad napred
                int firstOperand = Int32.Parse(calculatorStack.Pop());
                //int e tip specialno za C# a Int32 e tip za cqlata .Net
                //platforma
                string operand = calculatorStack.Pop();
                int secondOperand = Int32.Parse(calculatorStack.Pop());
                switch (operand)
                {
                    case "+":
                        calculatorStack.Push((firstOperand + secondOperand).ToString());
                        break;

                    case "-":
                        calculatorStack.Push((firstOperand - secondOperand).ToString());
                        break;

                }
            }
            Console.WriteLine(calculatorStack.Pop());

        }
    }
}
