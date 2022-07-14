// программу вывода случайного значения из диапазона 
//[10,99]
// 1. Уточнения по отрезку
//нужно ли считать дробные
// 2. Блок-схема

// int number = new Random().Next(10,100); //[10,100)

// Console.WriteLine($"number: {number}");
//int x = number/10;
//int y = number%10;
//if ( x > y )
//{
//    Console.WriteLine(x);
//}
//else
//{
//    Console.WriteLine(y);
//}



//Задача на массив. Массив из 8-ми элементов и вывести на экран
//Уточнение 
//буквы алфавита
//Прописные или строчные
// Случайные символы

// Метод создания массива
// Метод печати массива
// метод получения случайного символа
// Метод заполнения массива

//Метод создания массива
//строка 2гб. Война и мир 30мб
char[] CreatArray(int count)
{
    return new char[count];
}

// Метод печати массива
void Print(char[] array)
{
  int len = array.Length;
  int i = 0;
  while (i < len)
  {
    Console.WriteLine(array[i]);
    i++;
  } 
}
// Метод заполнения массива
void Fill(char[] array)
{
    int length = array.Length;
    int i=0;
    while (i < length)
    {
        array[i]='!';
        i++;
    }
}
char[] arg = CreatArray(8);
Fill(arg);
Print(arg);
