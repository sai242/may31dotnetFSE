using System;

namespace Evaluation
{
    class Program
    {
        int GetTheNonRepeatingNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int j;
                for (j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                        break;
                }
                if (j == arr.Length)
                    
                    return arr[i];
            }
            return -1;

        }

        void CheckIfNumberIsPrime(int num)
        {
            int a = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine($"The non repeating number, {num}, is a Prime Number");
            }
            else
            {
                Console.WriteLine($"The non repeating number,{num}, is not a Prime Number");
            }
        }
        
        static void Main(string[] args)
        {
            int[] numbers = { 90, 34, 8, 34, 70, 21, 21, 70, 8 };
            Program program = new Program();
            int number = program.GetTheNonRepeatingNumber(numbers);
            program.CheckIfNumberIsPrime(number);
            Console.ReadKey();

        }
    }
}
