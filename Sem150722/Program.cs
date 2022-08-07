// напишите программк, кото приним на вход координ точки х и у 
//не равн нулю и выдаёт номер четверти плоскости, в которой находится эта точка
//координаты в double
//[int TryDouble(string data, string text)

// double x = TryDouble(Console.ReadLine(), "Введите х:")
double x = 0;
bool flag = false;

double y = 0;
while (x == 0 && flag)

{

Console.WriteLine($"введите x:",3);
string str = Console.ReadLine();//text
int pos = 0;
flag = true;
while (pos<str.Length)
{
    if (str[pos]>= '0' && str[pos]<= '9')
    {
        flag = false;
        break;
    }
    pos++;
}
x = Convert.ToDouble(Console.ReadLine());
}


while (y == 0 && flag)

{

Console.WriteLine($"введите y:",3);
string str = Console.ReadLine();
int pos = 0;
flag = true;
while (pos<str.Length)
{
    if ((str[pos]>= '0' && str[pos]<= '9'))
    {
        flag = false;
        break;
    }
    pos++;
}
if (str == String.Empty) flag = false;
if (flag) y = Convert.ToDouble(str);


y = double.Parse(Console.ReadLine());
}

Console.WriteLine($"P{x};{y}");
if (x > 0 && y>0) {Console.Write ("1 четверть",3);}
if (x < 0 && y>0) {Console.Write ("2 четверть",3);}
if (x < 0 && y<0) {Console.Write ("3 четверть",3);}
if (x > 0 && y<0) {Console.Write ("4 четверть",3);}

//Console.WriteLine($"P({x};{y}) -> {GetResult(x, y)}");
