using System;

namespace even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int num =0; num <= 10; num ++)
                {
                    if (num % 2 == 0)
                    {
                            Console.WriteLine(num);
                    }
                }
        }
    }
}
