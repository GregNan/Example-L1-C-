/*string s = "qwqwqwqwqwqwqwqwqwewqwewqwe345";
Console.WriteLine($"pos 3: {s.LastIndexOf("qweq")}");
Console.WriteLine($"sub: {s.Substring(10)}");
Console.WriteLine($"sub: {s.Substring(10, 5)}");
Console.WriteLine($"sub: {s.Replace("qw","!")}");
*/
//Задача 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9;9]. Найдите сумму отрицательных элементов массива.
// создать пустой массив из 12
//заполнить -9 9
int[] array = new int [12];
void ArrayFill (int[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
}
void ArrayPrint (int[] array)
{
    for (int j = 0; j<array.Length; j++)
    {
        Console.Write($"{array[j]}");
    }
}
ArrayFill(array);
Console.WriteLine (array);
int a=0;
int b=0;
for (int i=0; i < array.Length; i++)
{ 
    if (array [i]>0) a=a+array[i];
    else b=b+array[i];
}
FillArray(array);
for (int i=0; i<array.Length; i++)
{
    array[i] = array[i]* -1;
}
PrintArray(array);
Console.WriteLine($"Новый массив: {Array[i]}");
ArrayPrint(array);
Console.WriteLine ($"сумма положительных чисел = {a}, отрицательных = {b}");


//Задача 33 Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*int[] array = new int[10];
int i=0;
FillArray(array);
PrintArray(array);

Console.Write("vvedite chislo");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("massiv ->");

for (int i=0; i < array.Length; i++)
{
    if (num == array[i]) Console.WriteLine($"chislo{num} esti v massive"));
    else Console.WriteLine($"chislo{num} ne prisutsvuet v massive");
    i++;
}
*/

//bool f = false;
/*for (int i=0; i<a.Length; i++)
{
    if (a[i] == find)
    {
        f =true;
    }
    
 
}*/

/*int i = 0;
while (i<a.Length)
{
    if (a[i] == find)
    {
        f =true;
    }
    i++
    
 
}*/
bool FindIndex(int[] arr, int el)
{
    bool f = false;
    int i = 0;
    while (i < arr.Length)
    {
        if (arr[i]==el)
        {
            return true;
        }
        i++;
    }
return false;
}
int[] a = {1,23,4,1,13,12,3,2,3,1,2,3,12};
int find = 8;
Console.WriteLine($"find: {find} {f}");
Console.WriteLine($"find: {find} {findIndex(a, find)}");