//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
/*Console.WriteLine ("Введите количество строчек двумерного массива");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов двумерного массива");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array1 = new int [row, column];


void PrintArray(int[,] array)
{
    for (int i=0; i< array.GetLength(0);i++)
    {
      for (int j=0; j< array.GetLength(1);j++)  
      {
        Console.Write(array[i,j]+ " ");
      }
      Console.WriteLine();
    }
}
void FillArray(int[,] array)
{
    for (int i=0; i< array.GetLength(0);i++)
    {
      for (int j=0; j< array.GetLength(1);j++)  
      {
        array[i,j]= new Random().Next(1, 10);
      }
      Console.WriteLine();
    }
}


void Sort(int[,] array)
{
  for (int i=0; i< array.GetLength(0);i++)
    {
      for (int j=0; j< array.GetLength(1);j++)  
      {
        int tmp = array[i,j];
        if (array[i,j]< array[i,j+1])
        {
          tmp= array[i,j];
          array[i,j]= array[i,j+1];
          array[i,j+1]=tmp;
          i++;
          j++;
        }
          
             
      }
      
    
    }

}
FillArray(array1);
PrintArray(array1);
Sort(array1);
PrintArray(array1);
Console.WriteLine();*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
/*1 4 7 2
  5 9 2 3
  8 4 2 4
  5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*//*
Console.WriteLine ("Введите количество строчек двумерного массива");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов двумерного массива");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array1 = new int [row, column];
int[] a = new int[row]; 

void PrintArray(int[,] array)
{
    for (int i=0; i< array.GetLength(0);i++)
    {
      for (int j=0; j< array.GetLength(1);j++)  
      {
        Console.Write(array[i,j]+ " ");
      }
      Console.WriteLine();
    }
}
void FillArray(int[,] array)
{
    for (int i=0; i< array.GetLength(0);i++)
    {
      for (int j=0; j< array.GetLength(1);j++)  
      {
        array[i,j]= new Random().Next(1, 10);
      }
      Console.WriteLine();
    }
}


int Summa(int[,] array, int[] a)
{
  int b =0;
  for (int i=0; i< array.GetLength(0); i++)
    {
      for (int j=0; j< array.GetLength(1);j++)  
            
      {
        int tmp=+ array[i,j];
        i++;
        j++; 
      a[i]=tmp;
      }
      if (a[i]>a[b])
      {
        b=i;
      }      
      return a[i];
      
      
    }
    
    
    return b;
  

}
FillArray(array1);
PrintArray(array1);
Summa(array1,a);  
Console.WriteLine();*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49



Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)

Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7*/
