using System.IO;

namespace FileFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
        }
    }
}
