using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Diagnostics.Metrics;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        public static void Main (string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] myArray = new int [50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            //static void PopulateArray(int [] myArray)
            //{

            //    Random random = new Random();
                
            //    for (int i = 0; i < myArray.Length; i++)
            //    {
            //        int randomnum = random.Next(0, 50);
            //        myArray[i] = randomnum;
            //    }
            //}

            //OR

            Populater(myArray);

            //TODO: Print the first number of the array
            Console.WriteLine($"First number of array: {myArray[0]}.");
            //TODO: Print the last number of the array            
            Console.WriteLine($"Last number of array: {myArray[myArray.Length]}.");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            //First Way

            Array.Reverse(myArray);
            for (int i = 0;i < myArray.Length;i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(myArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(myArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(myArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            
            List<int> myList = new List<int>();

            //TODO: Print the capacity of the list to the console

            Console.WriteLine(myList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
;

            //static void PopulateList(List<int> myList)
            //{

            //    Random random = new Random();

            //    for (int i = 0; i < myList.Count; i++)
            //    {
            //        int randomnum = random.Next(0, 50);
            //        myList.Add(randomnum);
            //    }
            //}

            //OR

            Populater(myList);

            //TODO: Print the new capacity

            Console.WriteLine(myList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list? Please type using digits 0 - 9");

            string searchNumStr = Console.ReadLine();

            int searchNum;
            int.TryParse(searchNumStr, out searchNum);

            if (searchNum == 0)
            {
                Console.WriteLine("Error: Invalid Input. Please make sure to use only digits 0 - 9.");
            }
            else if (searchNumStr == "0")
            {
                NumberChecker(myList, 0);
            }
            else
            {
                NumberChecker(myList, searchNum);
            }

            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            OddKiller(myList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results

            myList.Sort();

            for (int i = 0; i < myList.Count; i ++)
            {
                Console.WriteLine(myList[i]);
            }

            // OR

            //NumberPrinter(myList);

            Console.WriteLine("Sorted Evens!!");

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            
            //int listLength = myList.Count;

            //int[] newArray = new int[listLength];

            //for (int i = 0; i < myList.Count; i ++)
            //{
            //    newArray[i] = myList[i];
            //}

            //OR

            int[] newArray2 = myList.ToArray();

            //TODO: Clear the list

            myList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i <numberList.Count; i++)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(i);
                }
            }
            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool isInList = false;
            for (int i = 0; i < numberList.Count; i++)
            {
                if (searchNumber == numberList[i])
                {
                    Console.WriteLine($"{searchNumber} is in the number list.");
                    isInList = true;
                    break;
                }
            }
            if (isInList == false)
            {
                Console.WriteLine($"{searchNumber} is not in the number list");
            }

        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < numberList.Count; i++)
            {
                numberList[i] = rng.Next(0,50);
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            List<int> reverseList = new List<int>();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverseList.Add(array[i]);
            }
            for(int i = 0; i < reverseList.Count; i++)
            {
                Console.WriteLine(reverseList[i]);
            }
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
