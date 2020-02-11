﻿using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 8 };

            //Length
            Console.WriteLine("Length " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effects of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);


        }
    }
}
