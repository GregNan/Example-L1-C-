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
// char[] CreatArray(int count)
//{
//    return new char[count];
//}

// Метод печати массива
//void Print(char[] array)
//{
//  int len = array.Length;
//  int i = 0;
//  while (i < len)
//  {
//    Console.WriteLine(array[i]);
//    i++;
//  } 
//}
// Метод заполнения массива
//void Fill(char[] array)
//{
//    int length = array.Length;
//    int i=0;
//    while (i < length)
//    {
//        array[i]= Convert.ToChar(64+i);
//        i++;
//    }
//}
//char[] arg = CreatArray(8);
//Fill(arg);
//Print(arg);

//int lenght = 8;
//char[] arg = new char[lenght];
//int i = 0;
//while (i <lenght)
//{
//  int sc = Convert.ToInt32('а');
//  int ec = Convert.ToInt32('я');
//  arg[i] = Convert.ToChar(new Random().Next(sc, ec +1));
//  Console.WriteLine(arg[i]);
//  i++;

//}
//перевод из символа в цифру
//Console.WriteLine(Convert.ToInt32('9'.ToString())+ Convert.ToInt32(('9'.ToString())));

//string s = Console.ReadLine();
//int i = 0;
//int sum = 0;
//while (i <s.Length)
//{
//  sum = sum + Convert.ToInt32(s[i].ToString());
//  i++;
//}
//Console.WriteLine($"sum {sum}");

//43/ Написать программу замены массива на противоположный
//уточнения
//создать массив из 10-ти элементов
//тип массива int random (-10,10)
//умножаем элем на -1
//вывести в консоль
//int[] numbers = new int[10];
//int index=0;
//while (index < numbers.Length)
//{
//  numbers[index] = new Random().Next(-10, 11);
//  Console.Write($"{numbers[index],3}");
//  index++;
//}
//Console.WriteLine();
//index = 0;
//while (index<numbers.Length)
//{
//  numbers[index]= -numbers[index];
//  Console.Write($"{numbers[index],3}");
//  index++;
//}

//System.Console.WriteLine();

//с методами
int[] Create(int len)
{ 
  return new int[len];
}

void Print(int[] array)

{
  int len = array.Length;
  int i = 0;
  while (i < len)
  {
    Console.Write($"{array[i],3}");
    i++;
  }
  Console.WriteLine();
}
void Fill(int[] numbers)
{
  int index = 0;
  while (index < numbers.Length)
  {
    numbers[index] = new Random().Next(-10, 11);
    index++;
  }
}

void invert(int[] arr)
{
  int index = 0;
  while (index < arr.Length)
  {
    arr[index] = -arr[index];
    index++;
  }
}

System.Console.WriteLine();
int[] numbers = Create(10);
Fill(numbers);
Print(numbers);
invert(numbers);
Print(numbers);
