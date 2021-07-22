using System;

namespace dotNetTema_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Please insert number from 1 to 10");

            var searchInt = int.Parse(Console.ReadLine());

            var indexFound = FindIndexInArrayWithSearchValue(array, searchInt);
            if (indexFound == -1)
            {
                Console.WriteLine("Number searched ({0})not found", searchInt);
            }
            else
            {
                Console.WriteLine("Number array index is " + indexFound);
            }
        }

        private static int FindIndexInArrayWithSearchValue(int[] array, int searchInt)
        {
            var index = 0;
            for (int i = 0; i <= array.Length; i++)
            {
                if(array[i] == searchInt)
                {
                    index = i;
                    break;
                }

                else
                {
                    index =  - 1;
                }

            }
            return index;
        }
    }
}
