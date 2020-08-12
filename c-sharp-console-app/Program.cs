using System;

namespace c_sharp_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            do
            {
                Console.WriteLine($"Hello {x}");
                x++;
            } while (x < 10);

            Console.WriteLine("All Done!");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"For loop i = {i}");
            }
        }
    }
}
