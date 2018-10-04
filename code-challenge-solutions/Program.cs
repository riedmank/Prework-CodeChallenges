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
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = NumberGetter();
                Console.WriteLine($"Slot {i}: {array[i]}");
            }
            Console.WriteLine("Select a number to see if its in the array.");
            ScoreCalc(array, NumberGetter());
        }

        static void ScoreCalc(int[] arr, int target)
        {
            //Store userInput
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

        static int NumberGetter()
        {
            int userInput = 0;
            bool result = true;
            while(!(userInput > 0 && userInput < 11) || !result)
            {
                result = int.TryParse(Console.ReadLine(), out userInput);
                if(!(userInput > 0 && userInput < 11) || !result)
                {
                    Console.WriteLine("You have picked an invalid number. Please try again.");
                }
            }
            return userInput;
        }
    }
}
