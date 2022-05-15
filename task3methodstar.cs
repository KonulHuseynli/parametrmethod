using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {


            Printstar(5, 5);
        }
        static void Printstar(int en, int hundurluk)
        {

            for (int i = 0; i <= en; i++)

            {
                for (int j = 0; j < i; j++)

                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }

    }
}

