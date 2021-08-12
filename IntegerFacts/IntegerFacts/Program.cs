using System;

namespace IntegerFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tenInts = new int[10];
            FillArr(ref tenInts);
            foreach(int val in tenInts)
            {
                Console.WriteLine(val);
            }
            int highest, lowest, sum;
            decimal average;
            GetStats(out highest, out lowest, out sum, out average, tenInts);

            Console.WriteLine($"The highest value in the array is {highest}");
            Console.WriteLine($"The lowest value in the array is {lowest}");
            Console.WriteLine($"The sum of the array is {sum}");
            Console.WriteLine($"The average of the array is {average}");
        }


        private static void FillArr(ref int[] arr)
        {
            int i = 0;
            while(i < 10) {
                Console.WriteLine($"Please enter the element for the first position, enter 0 to stop");
                string enteredVal = Console.ReadLine();
                if(enteredVal == "0")
                {
                    break;
                }
                //check if it is an integer
                //use tryparse
                int checkNum;
                bool parseRes = int.TryParse(enteredVal, out checkNum);
                Console.WriteLine(parseRes);
                if (!parseRes)
                {
                    //the value could not be parsed from a string to an integer
                    Console.WriteLine($"The entry you just made is not an integer,please enter something else");
                }
                else
                {
                    arr[i] = checkNum;
                    Console.WriteLine($"Just filled {checkNum} in position {i}");
                    ++i;
                }

            }

            
        }
        private static void GetStats(out int highest, out int lowest, out int sum,out decimal average,params int[] arr)
        {
            Array.Sort(arr);
            highest = arr[arr.Length - 1];
            lowest = arr[0];

            int accumulator = 0;
            foreach(int val in arr)
            {
                accumulator += val;
            }

            sum = accumulator;
            //anuwaaa...if you divide an integer by and integer, the result will alway be an integer...so convert one of the operands to a decimal
            average = (decimal)accumulator / arr.Length;
        }

    }
}
