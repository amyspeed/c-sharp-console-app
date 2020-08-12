using System;
using System.Collections.Generic;

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

            // add all integers divisible by 3
            int sum = 0;
            for (int j = 0; j <= 20; j++)
            {
                if (j % 3 == 0)
                {
                    sum = sum + j;
                }
            }
            Console.WriteLine($"the sum of this loop is {sum}");


            // Arrays

            var names = new List<string> { "name", "Ana", "Felipe" };
            names.Add("Amy");
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
                //OR

            for (int k = 0; k < names.Count; k++)
            {
                Console.WriteLine($"Hello {names[k].ToUpper()}!");
            }

            int index = names.IndexOf("Amy");

            if (index == -1 )
            {
                Console.WriteLine("Can't find Amy!");
            }
            else
            {
                Console.WriteLine($"found {names[index]} at index {index}");
            }

            names.Sort();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


        }
    }
}
