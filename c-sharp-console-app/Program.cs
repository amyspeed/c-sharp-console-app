﻿using System;
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


            // FIBONACCI

            var fibonacci = new List<int> { 1, 1 };

            while (fibonacci.Count < 20)
            {

                var prev = fibonacci[fibonacci.Count - 1];
                var prev2 = fibonacci[fibonacci.Count - 2];

                fibonacci.Add(prev + prev2);
            }

            foreach (var item in fibonacci)
                Console.WriteLine(item);

            // OBJECTS


            var account = new BankAccount("Amy", 10000);
            Console.WriteLine($"Acount {account.Number} was created for {account.Owner} with {account.Balance}.");


        }
    }

    public class BankAccount
    {
        public string Number { get;  }

        public string Owner { get; set; }

        public decimal Balance { get;  }

        private static int accountNumberSeed = 1234567890;

        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            Balance = initialBalance;

            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
