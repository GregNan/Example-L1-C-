//Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
/*
Console.WriteLine ("Введите количество строчек двумерного массива");
int row = Convert.ToInt(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов двумерного массива");
int column = Convert.ToInt(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[row, column];
int[,] array1 = new int[row, column];

void PrintArray(int[,] arra2)
{
    for (int i=0; i< array2.GetLength(0);i++)
    {
      for (int j=0; j< array2.GetLength(1);j++)  
      {
        Console.Write(array2[i,j]+ " ");
      }
      Console.WriteLine();
    }
}
void FillArray(int[,] array3)
{
    for (int i=0; i< array2.GetLength(0);i++)
    {
      for (int j=0; j< array2.GetLength(1);j++)  
      {
        Console.Write(array3[i,j]+ " ");
      }
      Console.WriteLine();
    }
}
void ChangeRows (int[,] array4, int[,] array5)
{
    for(int index = 0; index < array4.GetLength(0); index++)
    {
        array[0, index] = array[row-1, index];
        array5[row-1, index] = array4[0, index];
    }
}

int[,] CopyArray(int[,] array)
{
    int[] t = new int[s.Length];
    for (int i =0; i<s.Length; i++)
    {
        t[i]=s[i];
    }
    return t;
}




FillArray(array);
array1= CopyArray(array);
PrintArray(array);
Console.WriteLine();
ChangeRows(array,array1);
PrintArray(array1);
*/
//Палиндром

//Console.WriteLine("vvedite chislo");
/*int[] a = {1,6,3,4,5};
int[] t= CopyArray(a);
int[] CopyArray(int[] array)
{
    int[] t = new int[4];
    for (int i =0; i<4; i++)
    {
        t[i]=a[4-i];
    }
    return t;
}
string s = Convert.ToString(a)!;
string s1 = Convert.ToString(t)!;
string s2,s3;

if ((s2=s[myIndex0])==(s3=s1[myIndex0]))
{
   Console.WriteLine("Palindrom");
}
else
{
    Console.WriteLine("ne palindrom");
} */
static bool IsPalindrom(int x)
{
bool flag = true;
string st = x.ToString();
for (int i = 0; i < st.Length / 2; i++)
flag &= st[st.Length - i - 1] == st[i];
return flag;
}
Console.WriteLine("vvedite chislo");
int x =Convert.ToInt32(Console.ReadLine());
bool b = IsPalindrom(x);
if (b==true)
{
 Console.WriteLine("pol");
}
if (b==false)
{
    Console.WriteLine("ne pol");
}

/*string s=Console.ReadLine()!;
string s1;
string Vozvrat(string arg)
{
for (int i=0; i< s.Length; i++)
{
 s1(i)=s(s.Length-i);
 i++;
}
if (s==s1)
{
    Console.WriteLine("Palindrom");
}
else
{
    Console.WriteLine("ne palindrom");
}
}
/*if (s[0] =s[4] && s[1]=s[3])
{
    Console.WriteLine("palindrom");
}
else
{
Console.WriteLine("ne palindrom");
}
Console.WriteLine();
*/






