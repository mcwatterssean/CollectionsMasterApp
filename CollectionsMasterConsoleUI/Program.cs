using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            var numbers = new int[50];
           
            Populater(numbers);
           
            Console.WriteLine($"{numbers[0]}");
             
            Console.WriteLine(numbers[^1]);

            Console.WriteLine("All Numbers Original");

            NumberPrinter(numbers);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(numbers);

            Console.WriteLine("-------------------");

            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var numList= new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine($"Capacity: {numList.Capacity}");
            
            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numList);

            //Print the new capacity
            Console.WriteLine($"New Capacity: {numList.Capacity}");

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
           

            int userNumber;
            bool isANumber;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out userNumber);

            } while (isANumber == false);

            NumberChecker(numList, userNumber);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(numList);
            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numList.Sort();
            NumberPrinter(numList);

            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var myArray = numList.ToArray();

            //Clear the list
            numList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }

            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if(numberList.Contains(searchNumber))
            {
                Console.WriteLine("Yes we have the number that you are looking for.");
            }  
            else
            {
                Console.WriteLine("That number does not exist in our list.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            while(numberList.Count < 51)
            {
                Random rng = new Random();

                var number = rng.Next(0, 50);
            
                numberList.Add(number);
            }
            NumberPrinter(numberList);
        }

        private static void Populater(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {

                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);

            }
        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);

            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
