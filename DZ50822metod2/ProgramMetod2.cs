//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
/*
int Chetnoe (int[] array)
{
    int size = array.Length;
    int a=0;
    int c=0;
    for (int i=0; i<size; i++)
    {   
        if((array[i] % 2) > 0) a=a+1;
    }
    return a;

}
int[] b = {126, 121, 123, 124};
int k = Chetnoe(b);
Console.WriteLine($"Kol-vo chetnyh: {k}");
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

int[] array = new int [4];
void ArrayFill (int[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
}
void ArrayPrint (int[] array)
{
    for (int j = 0; j<array.Length; j++)
    {
        Console.Write($"{array[j]}");
    }
}

int Summa(int[] array)
{
    int a=array[0];
    for (int i=0; i < array.Length; i++)
    {
    if((i%2>0)) a= a+ array[i];
    }
    return a;
}
ArrayFill(array);
Console.WriteLine (array);
int l = Summa(array);
Console.WriteLine($"Summa: {l}");

