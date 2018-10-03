using System;

namespace code_challenge_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            InputGetter();
        }

        static void InputGetter()
        {
            Console.WriteLine("Please provide 5 numbers between 1 and 10.");
            int[] array = new int[5];
            int userInput = 0;
            int target = 0;
            for (int i = 0; i < array.Length; i++)
            {
                userInput = Int32.Parse(Console.ReadLine());
                if (userInput > 0 && userInput < 11)
                {
                    array[i] = userInput;
                    Console.WriteLine($"Slot {i}: {array[i]}");
                }
                else
                {
                    Console.WriteLine("You did pick a valid number. Try again.");
                    i--;
                }
            }
            Console.WriteLine("Select a number to see if its in the array.");
            target = Int32.Parse(Console.ReadLine());
            ScoreCalc(array, target);
        }

        static void ScoreCalc(int[] arr, int target)
        {
            int userTarget = target;
            int[] userArray = arr;
            int counter = 0;
            foreach (int val in userArray)
            {
                if (val == userTarget)
                {
                    counter++;
                }
            }
            Console.WriteLine($"User Score: {counter * userTarget}.");
        }
    }
}
