using System.IO;

namespace FileFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }

        }
    }
}
