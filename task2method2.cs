using System;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 24 };
            PrintArraySum(12,24);
           
        }
        static int PrintArraySum (int [] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
                Console.WriteLine(sum);
                if(sum%2==0)
                {
                    return sum % 2;
                } 
            } return -1;
        }
        
    }
}
