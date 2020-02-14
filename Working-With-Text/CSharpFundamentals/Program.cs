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

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);
        }
    }
}
