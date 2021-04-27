using System;

namespace AppManString2IntTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string");

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                //Check weather it its an number with coresponsiding ASCII index
                if (input[i] >= 48 && input[i] <= 57)
                {
                    int number = input[i];
                    // Convert to coresponding number with ASCII offset
                    number = number - 48;
                    Console.Write(number);

                    
                }
            }
        }
    }
}
