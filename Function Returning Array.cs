using System;
class Program
    {
        static void Main(string[] args)
        {   
            int arraySize;
            Console.Write("Enter the size of Array: ");
            arraySize = int.Parse(Console.ReadLine());
            int[] arrayOfIntegers = new int[arraySize];
            Console.WriteLine("Enter the {0} integers values for array: ", arraySize);

            for (int i = 0; i < arraySize; i++)
            {
                arrayOfIntegers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Old Values of Array is :");
            PrintArrays(arrayOfIntegers);

            int[] newArrayOfIntegers = new int[arraySize];

            newArrayOfIntegers = ReturningChangesInArray(arrayOfIntegers);
            Console.WriteLine("New values of Array is :");
            PrintArrays(newArrayOfIntegers);
        }

        static int[] ReturningChangesInArray(int[] integers)
        {
            Console.Write("Enter the number of values which needs to be changed: ");
            int numberOfChanges = int.Parse(Console.ReadLine());

            for (int i = 1; i<=numberOfChanges; i++)
            {
                Console.Write("Enter the index of array which needs to be changes: ");
                int arrayIndex = int.Parse(Console.ReadLine());

                Console.Write("Enter the value of {0} index of array : ", arrayIndex);
                int arrayIndexValue = int.Parse(Console.ReadLine());

                integers[arrayIndex] = arrayIndexValue;
            }
            return integers;
        }

        static void PrintArrays(int[] printableArrays)
        {
            for (int i = 0;i < printableArrays.Length;i++)
            {
                Console.WriteLine(printableArrays[i]);
            }
        }
    }