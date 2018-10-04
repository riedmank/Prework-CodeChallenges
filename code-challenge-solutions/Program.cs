using System;

namespace code_challenge_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayMaxResult();
            //LeapYearCalc();
            //Test Array
            int[] testArray = new int[] { 0, 0, 0, 0 };
            Console.WriteLine($"Array contains a perfect sequence: {PerfectSequence(testArray)}.");
        }

        static void ArrayMaxResult()
        {
            Console.WriteLine("Please provide 5 numbers between 1 and 10.");
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                //Request userInput and insert into array
                array[i] = NumberGetter();
                Console.WriteLine($"Slot {i}: {array[i]}");
            }
            Console.WriteLine("Select a number to see if its in the array.");
            //Pass user array and user target to ScoreCalc method
            ScoreCalc(array, NumberGetter());
        }

        static void ScoreCalc(int[] userArray, int target)
        {
            //Counter for finding matches
            int counter = 0;
            foreach (int val in userArray)
            {
                if (val == target)
                {
                    counter++;
                }
            }
            Console.WriteLine($"User Score: {counter * target}.");
        }

        static int NumberGetter()
        {
            //Requests userInput and validates response
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
            //Return valid response
            return userInput;
        }

        static void LeapYearCalc()
        {
            int year = -1;
            //Allows user to check years until they are finished
            while (year != 0)
            {
                Console.WriteLine("Provide a year to see if it is a leap year. Enter 0 to quit.");
                bool result = int.TryParse(Console.ReadLine(), out year);
                if ((year % 4) == 0)
                {
                    if ((year % 100) != 0)
                    {
                        Console.WriteLine($"{year} is a Leap Year");
                    }
                    else if ((year % 100) == 0 && (year % 400) == 0)
                    {
                        Console.WriteLine($"{year} is a Leap Year");
                    }
                    else
                    {
                        Console.WriteLine($"{year} is not a Leap Year");
                    }
                }
                else
                {
                    Console.WriteLine($"{year} is not a Leap Year");
                }
            }
        }

        static string PerfectSequence(int[] userArray)
        {
            int sum = 0;
            int product = 1;
            foreach (int val in userArray)
            {
                //Discard negative values right away
                if (val < 0)
                {
                    return "no";
                }
                sum += val;
                product *= val;
            }
            //Compare sum and product
            if (product == sum)
            {
                return "yes";
            }
            else
            {
                return "no";
            }
        }
    }
}
