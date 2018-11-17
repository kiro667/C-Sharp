using System;
using System.Collections.Generic;

namespace _4.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();//!!!

            var expressionFinder = new Stack<int>(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') {
                    expressionFinder.Push(i);
                }
                if (input[i] == ')') {
                    int start = expressionFinder.Pop();//tova 6te mi dade
                    // na koq poziciq e skobata
                    Console.WriteLine(input.Substring(start,i-start+1));//???
                }


            }



        }
    }
}
