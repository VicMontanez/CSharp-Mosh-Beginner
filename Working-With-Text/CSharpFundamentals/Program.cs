﻿using System;
using System.Text;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");

            builder.Append('-', 10)
            .AppendLine()
            .Append("Header")
            .Append('-', 10)

            .Replace('-', '+')
            .Remove(0, 10)
            .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]);
        }
    }


}
