using System;

namespace Lab2
{
    public class Lab
    {
        public int FindMinimum(int a, int b)
        {
            return Math.Min(a, b);
        }

        public int FindMinimum(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }

        public void ExecuteBasedOnLastDigit()
        {
            int lastDigit = 11810163 % 10;

            if (lastDigit == 2 || lastDigit == 3)
            {
                // Example: Calling FindMinimum with 2 and 3
                int result2 = FindMinimum(10, 20);
                int result3 = FindMinimum(30, 40, 50);

                Console.WriteLine("Minimum of 2 numbers: " + result2);
                Console.WriteLine("Minimum of 3 numbers: " + result3);
            }
            else
            {
                Console.WriteLine("Last digit is not 2 or 3. No action taken.");
            }
        }
    }
}

