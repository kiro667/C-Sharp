using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calc
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            var values = input.Split(" ");//!!!

            var calculatorStack = new Stack<string>(values.Reverse());
            //reverse e za6toto v while cikula po4vam da gi vurtq ot posledcniq
            //element do 0-viq
            while (calculatorStack.Count > 1)
            {
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
