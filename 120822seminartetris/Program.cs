int width = Console.WindowWidth;
int height = Console.WindowHeight;

Console.WriteLine($"width: {width}");
Console.WriteLine($"height: {height}");
void Print(int x, int y)
{
    for (int r = x-1; r < x +1; r++)
    {
        for (int c=y-1; c < y+1; c++)
        {
            Console.SetCursorPosition(x,y);
            Console.Write("+");
        }
    }
}
int x = 3; int dx=1;
int y = 4; int dy=1;
Console.CursorVisible = false;
Random r = new Random();

while (true)
{
    Console.Clear();

    Console.SetCursorPosition(x, y);
    
    Console.Write("X");
    Print(x,y);
    if (x > width -2 || x < 1) dx = -dx;
    if (y > height -2 || y < 1) dy = -dy;
    x += dx; y+=dy;
    //Console.WriteLine($"x: {x} y: {y}");
    
    
    Thread.Sleep(10);

}
