using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Victor Montanez ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim);
            
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim.ToUpper());
        }
    }
}
