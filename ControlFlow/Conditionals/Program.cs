using System;

namespace Conditionals
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                Console.WriteLine("Its perfect weather.");
                break;

                default:
                Console.WriteLine("I don't understand that season!");
                break;

                
            }
        }
    }
}
