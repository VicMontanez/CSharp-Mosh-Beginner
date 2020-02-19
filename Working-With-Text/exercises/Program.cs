using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            var name = Console.ReadLine();

            var reversed = ReversedName(name);
            Console.WriteLine("Reversed name: " + reversed);


            Console.WriteLine("Reversed name: " + reversed);

            // return reversed;
        }

        public static string ReversedName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            return new string(array);


        }
    }
}
