// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] arrey=new int [m,n];
for (int i=0; i<arrey.GetLength(0); i++)
   {for (int j=0; j<arrey.GetLength (1); j++)
    {
        arrey [i,j]=new Random().Next(-100,100);
        Console.Write ($"{arrey[i,j]}  ");
    }
    Console.WriteLine ();
   }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] arrey=new int [m,n];
for (int i=0; i<arrey.GetLength(0); i++)
   {for (int j=0; j<arrey.GetLength (1); j++)
    {
        arrey [i,j]=new Random().Next(-100,100);
        Console.Write ($"{arrey[i,j]}  ");
    }
    Console.WriteLine ();
   }
Console.WriteLine("Введите номер строки:");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int n1 = Convert.ToInt32(Console.ReadLine());
if (m1>m || n1>n)
{ Console.WriteLine("Такого элемента нет");}
else
for (int i=0; i<arrey.GetLength(0); i++)
{   for (int j=0; j<arrey.GetLength (1); j++)
    { if ((i+1)==m1 && (j+1)==n1)
       {Console.WriteLine ($"{arrey[i,j]} ");}
    }
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int [,] arrey=new int [m,n];
for (int i=0; i<arrey.GetLength(0); i++)
   {for (int j=0; j<arrey.GetLength (1); j++)
    {
        arrey [i,j]=new Random().Next(1,10);
        Console.Write ($"{arrey[i,j]}  ");
    }
    Console.WriteLine ();
   }
for (int j=0; j<arrey.GetLength(1); j++)
    {double sum = 0;
        for (int i=0; i<arrey.GetLength (0); i++)
        {
            sum=sum+arrey [i,j];
        }
    Console.Write ($"{sum/arrey.GetLength (0)}  ");
    Console.WriteLine ();
   }