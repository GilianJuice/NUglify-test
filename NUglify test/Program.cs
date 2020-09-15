using System;
using System.IO;
using NUglify;

namespace NUglify_test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var test = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "test.js"));
                Console.WriteLine($"Input: {test}");

                var result = Uglify.Js(test);
                Console.WriteLine($"Output: {result}");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            Console.ReadLine();
        }
    }
}
