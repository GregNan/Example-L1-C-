/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
int m=3;
int n=4;


void Zap (int[,] array)
{
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            array[i,j] = new Random().Next(-9,10);
        }
   
    }

}

void Print (int[,] array)
{
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            Console.Write($" {array[i,j]}");
    
        }
    Console.WriteLine();
    }

}


int[,] array = new int [m,n];

Zap(array);
Print(array);*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

int[,] array = new int[2, 3] {
    {1,2,3},
    {4,5,6},
    };
object c = 0;

     
 object Vyvod (int[,] array)
 {
    Console.WriteLine("Введите координаты");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
        if (a>2 && b>3)
            Console.WriteLine("такого числа нет");
            else
        {
            c = array.GetValue(a,b);
    return c;  
 }
 }
 Vyvod(array);
Console.WriteLine(c);
*/

/* Задача 52. Задайте двумерный массив из целых чисел размера NxN. 
Укажите два числа,означающие строки, которые нужно поменять местами.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
9 8 7 2
число 1 -1
число 2 -3 

Итог:
1 2 7 4
5 3 2 9
8 4 2 4
9 2 7 8*/

