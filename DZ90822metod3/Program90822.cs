//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3



/*void VvodChisel (int[] array)
{
    for (int i=0; i<5; i++)
    {
        
        array[i]=Console.ToString(Console.ReadLine());
    }
    return;
}*/
/*
int Schet (int[] array)
{
    int m=0;
    for (int i=0; i<5; i++)
    {
        if (array[i]>0)
        m+=1;
    }
   return m;
}

//Console.WriteLine("vvedite chislo");
//int[] a = Console.ReadLine();
int [] a = {0, 7, 8, -2, -2};
Console.WriteLine(a);
int l= Schet(a);
Console.WriteLine($"kolvo pologit: {l}");*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

/*double b1= Console.ReadLine();
Console.ReadLine();
double b2= Console.ToIntDouble(Console.ReadLine());
Console.ReadLine();
double k2= Console.ToDouble(Console.ReadLine());
Console.ReadLine();
double k1= Console.ToDouble(Console.ReadLine());
Console.ReadLine();
double y =0;
double x=0;*/
/*double b1= 2;
double b2= 4;
double k2= 9;
double k1= 5;*/

double y1 =0;
double x1=0;
double [x1,y1] Tochka(int[] array)
{
    double x1=(array[1]-array[0])/(array[2]-array[3]);
    double y1= array[1]*x1+array[3];
    /*x1=(b2-b1)/(k1-k2);
    y2= k2*x+b2;*/
    return x1;
    return y1;
}
double l={5, 9, 2, 4};

Console.Write($"Koordinati: {x1}; {y1}");
//11



