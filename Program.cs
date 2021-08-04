using System;

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
        static void Resize(ref int[] arrayToResize, uint newLengthOfArray)
        {
            int lengthOfSavingData = arrayToResize.Length>newLengthOfArray ? Convert.ToInt32(newLengthOfArray) : arrayToResize.Length;
            int[] arrayForSavingData = new int[lengthOfSavingData];

            for (int currentElement = 0; currentElement < lengthOfSavingData; currentElement++)
            {
                arrayForSavingData[currentElement] = arrayToResize[currentElement];
            }

            arrayToResize = new int[newLengthOfArray];
            for (int currentElemnt = 0; currentElemnt < arrayForSavingData.Length; currentElemnt++)
            {
                arrayToResize[currentElemnt] = arrayForSavingData[currentElemnt];
            }
            return;
        }
        /// <summary>
        /// Метод изменяет количество элементов в массиве на заданное. Пареаметр определяющий количество элементов передаётся в виде string.
        /// </summary>
        /// <param name="arrayToResize"></param>
        /// <param name="newLengthOfArrayString"></param>
        /// <returns></returns>
        static void Resize(ref int[] arrayToResize, string newLengthOfArrayString) 
        {
            uint newLengthOfArray;

            if (uint.TryParse(newLengthOfArrayString, out newLengthOfArray)) {} 
            else 
            {
                Console.WriteLine("Введёное вами значение некорректно. Приемлимы только целочисленные значения без знака.");
                return;
            }

            int sizeOfSavingData = arrayToResize.Length > newLengthOfArray ? Convert.ToInt32(newLengthOfArray) : arrayToResize.Length;
            int[] arrayForSavingData = new int[sizeOfSavingData];

            for (int currentElement = 0; currentElement < sizeOfSavingData; currentElement++)
            {
                arrayForSavingData[currentElement] = arrayToResize[currentElement];
            }

            arrayToResize = new int[newLengthOfArray];
            for (int currentElemnt = 0; currentElemnt < arrayForSavingData.Length; currentElemnt++)
            {
                arrayToResize[currentElemnt] = arrayForSavingData[currentElemnt];
            }

            return;
        }
        static void Main()
        {
            int[] arrayForTests = new int[3] {1, 2, 3 };
            string stringNewLengthOfArray;
            uint uintNewLengthOfArray;

            Console.WriteLine("Изначальный массив");
            foreach (var item in arrayForTests)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            Console.Write("Введите новое количество элементов: \t");
            stringNewLengthOfArray = Console.ReadLine();
            Console.WriteLine();


            try
            {
                uintNewLengthOfArray = uint.Parse(stringNewLengthOfArray);
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели некорректное значение для новой длины массива. Приемлимы только целочисленные значения без знака.");
                uintNewLengthOfArray = 0;
            }

            Resize(ref arrayForTests,uintNewLengthOfArray);
            Console.WriteLine("Массив после обработки методом Resizeс переданным значением длины массива в формате uint:");
            foreach (var item in arrayForTests)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            arrayForTests = new int[3] { 1, 2, 3 };

            Resize(ref arrayForTests, stringNewLengthOfArray);
            Console.WriteLine("Массив после обработки методом Rsize с переданным значением длины массива в формате string:");
            foreach (var item in arrayForTests)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для завершения выполнения программы.");
            Console.ReadKey();

        }
    }
}
