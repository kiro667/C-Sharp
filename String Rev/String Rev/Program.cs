using System;
using System.Collections.Generic;

namespace String_Rev
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stringReverser = new Stack<char>();

            string input = Console.ReadLine();

            foreach (var ch in input)
            {
                stringReverser.Push(ch);
            }

            while (stringReverser.Count > 0)
            {
                Console.Write(stringReverser.Pop());
            }
            Console.WriteLine();
        }
    }
}
