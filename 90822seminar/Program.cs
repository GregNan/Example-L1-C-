/*Random rand = new Random();
int i = rand.Next(1,10);

// [0;1) -> *10-> [0;10)->-5->[-5;5)
double d = rand.NextDouble()*10-5;
Console.Writeline($"d:{d}");
d = Math.Round(d,2);
d = 4.999*100;
d = Math.Floor(d)/100;*/

/*int[] a ={1,2,3,4,5};
int[,] map = new int[4, 3] {
    {76,11,99},
    {56,23,13},
    {43,34,55},
    {22,44,11},
};
Console.WriteLine($"map[1,1]: {map[1, 1]}");

int sum =0;
for (int row=0; row<4; row++)
{
    for (int col = 0; col <3; col++)
    {
        sum += map[row, col];
    }
}
Console.WriteLine($"value: {sum}");*/



// сложение матриц

void Print (int[,] matr)
{
    for (int i = 0; i< matr.GetLength(1); i++)
    {
        for (int j = 0; j< matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]}");
        }
    Console.WriteLine();
    }
}
void FillMatric (int[,] matr) {
    for (int i=0; i< matr.GetLength(0); i++)
    {
        for (int j=0; j< matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 100);
        }
    }
}
void PlusMatric (int[,] matr, int[,] matr2)
{
    int [,] result = new[row,col];
    for (int i=0; i< matr.GetLength(0); i++)
    {
        for (int j=0; j< matr.GetLength(1); j++)
        {
            int mult = matr[i,j]*matr1[i,j] + matr[i,j+1]*matr1[i+1,j]*matr[i,j+2]*matr1[i+2,j];
            Console.WriteLine($"{sum}");
        }
    }
}



Console.Write("Введите количество строк:");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов:");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matric = new int[row, column];
FillMatric(matric);

int[,] matric1 = new int[row, column];
FillMatric(matric1);
Print(matric);
Console.Writeline();
Print(matric1);
PlusMatric(matric, matric1);


