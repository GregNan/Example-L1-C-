//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
int i=12345;
double a;
double b;
double c;
double d;
double e;
double g;
double w;
double z;
Console.WriteLine ("vvedite i:");
//Console.ReadLine(i);
    
        a=i/10000;
        e=i/1000;
        b=e%10;
        d=i%10;
        g=i/10;
        c=g%10;
        w=(a*b)/(a/b);
        z=(c*d)/(c/d);
//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(d);
if (a=d & b=c)
{
    Console.WriteLine("Палиндром");
}
Console.WriteLine();
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

static void Main(string[] args)
    {
        char selection;
        Double x1, x2, y1, y2, z1, z2, distance;

        Console.WriteLine("1. Расстояние между двумя точками на плоскости.");
        Console.WriteLine("2. Расстояние между двумя точками в пространстве.");
        Console.WriteLine("Выберите нужный пункт (1 или 2):");

        selection = Convert.ToChar(Console.ReadLine());

        switch (selection)
        {
            case '1':
                Console.Write("Введите координаты x1: ");
                x1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты x2: ");
                x2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты y1: ");
                y1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты y2: ");
                y2 = Convert.ToDouble(Console.ReadLine());

                distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
                Console.ReadKey();
                break;
            case '2':
                Console.Write("Введите координаты x1: ");
                x1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты x2: ");
                x2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты y1: ");
                y1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты y2: ");
                y2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты z1: ");
                z1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты z2: ");
                z2 = Convert.ToDouble(Console.ReadLine());

                distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
                Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Вы ввели неверный символ");
                Console.ReadKey();
                break;
        }

    }

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int i;
int N;
for (int i=0; i<N; i++)
{
    Console.Writeline($"{i!}";
}
