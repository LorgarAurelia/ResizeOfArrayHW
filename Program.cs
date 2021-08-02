using System;
using System.ComponentModel;

/*
 * Написать метод изменяющий количество эллементов массива
 */

namespace ResizeOfArrayHW
{
    class Program
    {
        /// <summary>
        /// Метод изменяет количество элементов в массиве на заданное. Пареаметр определяющий количество элементов передаётся в виде uint.
        /// </summary>
        /// <param name="arrayToResize"></param>
        /// <returns></returns>
        static ref int[] Resize(ref int[] arrayToResize, uint newSizeOfArray)
        {
            int sizeOfSavingData = arrayToResize.Length>newSizeOfArray ? Convert.ToInt32(newSizeOfArray) : arrayToResize.Length;
            int[] arrayForSavingData = new int[sizeOfSavingData];

            for (int currentElement = 0; currentElement < sizeOfSavingData; currentElement++)
            {
                arrayForSavingData[currentElement] = arrayToResize[currentElement];
            }

            arrayToResize = new int[newSizeOfArray];
            for (int currentElemnt = 0; currentElemnt < arrayForSavingData.Length; currentElemnt++)
            {
                arrayToResize[currentElemnt] = arrayForSavingData[currentElemnt];
            }
            return ref arrayToResize;
        }
        /// <summary>
        /// Метод изменяет количество элементов в массиве на заданное. Пареаметр определяющий количество элементов передаётся в виде string.
        /// </summary>
        /// <param name="arrayToResize"></param>
        /// <param name="newSizeOfArrayString"></param>
        /// <returns></returns>
        static ref int[] Resize(ref int[] arrayToResize, string newSizeOfArrayString) 
        {
            uint newSizeOfArray;

            if (uint.TryParse(newSizeOfArrayString, out newSizeOfArray)) {} 
            else 
            {
                Console.WriteLine("Введёное вами значение некорректно. Приемлимы только целочисленные значения без знака.");
                return ref arrayToResize;
            }

            int sizeOfSavingData = arrayToResize.Length > newSizeOfArray ? Convert.ToInt32(newSizeOfArray) : arrayToResize.Length;
            int[] arrayForSavingData = new int[sizeOfSavingData];

            for (int currentElement = 0; currentElement < sizeOfSavingData; currentElement++)
            {
                arrayForSavingData[currentElement] = arrayToResize[currentElement];
            }

            arrayToResize = new int[newSizeOfArray];
            for (int currentElemnt = 0; currentElemnt < arrayForSavingData.Length; currentElemnt++)
            {
                arrayToResize[currentElemnt] = arrayForSavingData[currentElemnt];
            }

            return ref arrayToResize;
        }
        static void Main()
        {
            
        }
    }
}
