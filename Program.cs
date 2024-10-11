using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8.PracticWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows; // Строки
            int columns; // Столбцы
            int[,] firstMatrix;
            int[,] secondMatrix;
            int[,] sumMatrix;
            int sum = 0;
            Random rnd = new Random();

            #region Task 1

            Console.WriteLine("Создание матрицы чисел");
            Console.Write("Введите кол-во строк в будущей матрице чисел: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов в будущей матрице чисел: ");
            columns = int.Parse(Console.ReadLine());
            firstMatrix = new int[rows, columns];
            for(int i = 0; i < rows; i++) 
            {
                for(int j = 0; j < columns; j++)
                {
                    firstMatrix[i, j] = rnd.Next(1, 99);
                    sum += firstMatrix[i, j];
                    Console.Write($"{firstMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма чисел первой матрицы: {sum}");

            #endregion

            #region Task 2

            Console.WriteLine("Вторая матрица чисел:");
            secondMatrix = new int[rows, columns];
            sumMatrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    secondMatrix[i, j] = rnd.Next(1, 99);
                    Console.Write($"{secondMatrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма двух матриц:");
            for (int i = 0; i < rows;i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    sumMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                    Console.Write($"{sumMatrix[i, j]} ");
                }
                Console.WriteLine();
            }

            #endregion
            Console.ReadKey();
        }
    }
}
