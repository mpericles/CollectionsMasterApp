using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbers = new int[50];

            Console.WriteLine("ARRAY SECTION RESULTS");

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            //TODO: Print the first number of the array
            int i = 0;
            Console.WriteLine("Print the first number of the array");
            Console.WriteLine(numbers[i]);
            Console.WriteLine(" ");

            //TODO: Print the last number of the array            
            Console.WriteLine(" ");
            Console.WriteLine("Print the last number of the array");
            Console.WriteLine(numbers[49]);
            Console.WriteLine(" ");

            //UNCOMMENT this method to print out your numbers from arrays or lists
            Console.WriteLine("Print the array");
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            Array.Reverse(numbers);
            // Print the reversed array
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("---------REVERSE CUSTOM------------");
            int[] reversedNumbers = ReverseArray(numbers);
            // Print the reversed array
            foreach (int num in reversedNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Print to the console the array with Multiple of three set to 0");
            ThreeKiller(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

        
        #region Lists
        Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            //var numList = new List<int>();
            List<int> numList = new List<int>() { 1, 2, 3, 4, 5 };

        //TODO: Print the capacity of the list to the console
        Console.WriteLine("LIST SECTION RESULTS");
            Console.WriteLine("Print the capacity of the list to the console");
            //Console.WriteLine($"{numList.Capacity}");
            Console.WriteLine(" Capacity using the .Count");
            Console.WriteLine(numList.Count);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numList);


        //TODO: Print the new capacity
        //Console.WriteLine("Print the new capacity");
        //Console.WriteLine("Print the New capacity of the list to the console");
        //Console.WriteLine(" Capacity using the Capacity Function");
        //Console.WriteLine($"{numList.Capacity}");
            Console.WriteLine(" New Capacity using the .Count");
            Console.WriteLine(numList.Count-1);


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int numberLookingfor = int.Parse(Console.ReadLine());
            NumberChecker(numList, numberLookingfor);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numList);
            NumberPrinter(numList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numList.Sort();
            NumberPrinter(numList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            //Not sure I did this correctly
            numList.ToArray();
            Console.WriteLine("Convert the list to an array and store that into a variable");
            NumberPrinter(numList);

            //TODO: Clear the list
            numList.Clear();
            Console.WriteLine("Print the cleared list");
            NumberPrinter(numList);
            Console.WriteLine(" ");
            Console.WriteLine("The List is cleared");
            Console.WriteLine(" ");
            Console.WriteLine("\n************End Lists*************** \n");
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
                
            }
        }
           
        
        private static void OddKiller(List<int> numberList)
        {
            //Change for loop to iterate from end to beginning instead of beginning to end
           //for (int i = 50; i < numberList.Count; i-- )
            for (int i = 50; i >= 0; i--)
                // start from end; fix modulus
                {
                //using the Moduluss function to remove the odd numbers
                if (numberList[i] % 2 != 0)
                {
                    // Remove at a specified index. not what we want
                    numberList.RemoveAt(i);
                    
                    //numberList.Remove(numberList.IndexOf(i));
                }

            }
        }
        

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool foundNunber = false;
            foreach (var item in numberList)
            {
                if (item == searchNumber)
                {

                    Console.WriteLine($"{searchNumber} is in your List");
                    foundNunber = true;
                    break;
                }
            }
            if (foundNunber == false)
            {
                Console.WriteLine($"{searchNumber} is NOT in your List");
            }
        }

        private static void Populater(List<int> numberList)
        {

            while (numberList.Count < 51)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);
                numberList.Add(number);
            }

        }          

        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);
                
            }

        }        

        //private static void ReverseArray(int[] numbers) // used a different static header
        static int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];

            //This is working but not reversing the numbers like the other reverse unless the other one is not working
            for (int i = 0; i < array.Length; i++)
            {
              reversedArray[i] = array[array.Length - 1 - i];
            }

            //for (int i = 49; i < array.Length; i--)
            //{
              //  reversedArray[i] = array[array.Length - 1 - i];// caused an exception
            //}

            return reversedArray;
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
