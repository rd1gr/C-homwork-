// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
//  вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



// void FillArrayRandomNumbers(double[,] array)
// {
//        for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//                for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//             Console.WriteLine("");
//     }
// }
// Console.WriteLine("введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[rows, columns];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);


// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("введите номер строки");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int b = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [10,10];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// if (a > numbers.GetLength(0) || b > numbers.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {a} строки и {b} столбца равно {numbers[a-1,b-1]}");
// }

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(-100, 100)/10;
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//                for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }   
//              Console.WriteLine(""); 
//     }
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Random random = new Random();
// int[,] array = new int[random.Next(1, 10), random.Next(1, 10)];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = random.Next(1, 10);
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(" ");
// Console.WriteLine(array.GetLength(0));
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     double sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum += array[i, j];
//     }
//     Console.Write($"{ sum / array.GetLength(0)} ");
// }
// Console.ReadLine();


