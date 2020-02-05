using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // var number = "1234";
            // int i = Convert.ToInt32(number);
            // Console.WriteLine(i);
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }

            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }


        }
    }
}
