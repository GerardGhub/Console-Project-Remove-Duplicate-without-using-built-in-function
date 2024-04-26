using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Project
{
    internal class Program
    {


        #region
        /// <summary>
        /// To remove duplicates from an array without using built-in functions, implement a custom algorithm to iterate through the array, maintain a list of unique elements,  and filter out duplicates
        /// </summary>
        /// <param name="args"></param>
        


        static void Main(string[] args)
        {
            //Array given examples
            int[] array = { 1,2,2,3,4,4,5,6,6,7,8,8};

            //Remove duplicates

            int[] uniqueArray = RemoveDuplicates(array);

            //Print the unique array
            Console.Write("Array without duplicates");
            Console.WriteLine();
            PrintArray(uniqueArray);
            Console.ReadLine();



        }

        //Function to remove duplicates from an array
        public static int[] RemoveDuplicates(int[] array) {

            //Initialize an empty list to store unique elements
            int[] uniqueArray = new int[array.Length];
            int uniqueCount = 0;

            //Iterate through the array
            foreach (int num in array)
            {
                //Check if the element is not already in the UniqueArray
                if (!Contains(uniqueArray, num))
                {

                    // Add the element to the uniqueArray
                    uniqueArray[uniqueCount] = num; 
                    uniqueCount++;
                }

            }

            // Resize the uniqueArray to removed unused space
            Array.Resize(ref uniqueArray, uniqueCount);


            return uniqueArray;
        
        }


        // Function to check if an array contains a specific element
        public static bool Contains(int[] array, int num) {
            foreach (int item in array)
            {
                if (item == num)
                {
                    return true;
                }
            }
            return false;
        }


        //Function to print an array 
        public static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine();
        }
        #endregion


    }
}
