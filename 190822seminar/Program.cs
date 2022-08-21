/* n=до 30 000
нужно вычислить разложение первых n
чисел на простые множители*/

//int fs =2; // 
//              div   mod  mod==0  fs
//int n=50;     //0       0           2
              //n/fs    n%fs true   2
              //
/*for (int x=2; x<10; x++)
{
    int n=x;
    string s = $"{x} = ";;
    int fs = 2;
    while (n != 1)
    {
        int mod = n%fs;
        if (mod ==0)
        {
            n=n/fs;
            s+= $"{fs}";
            fs =2;
        }
        else
        {
            fs++;
        }
        Console.WriteLine($"s: {s}");
    }
}
*/
/*
for (int x = 30000; x < 31000; x++)
{
  int n = x;
  string s = $"{x} = "; ;
  int fs = 2;
  while (n != 1)
  {
    int mod = n % fs;
    if (mod == 0)
    {
      n = n / fs;
      s += $"{fs} ";
      fs = 2;
    }
    else
    {
      fs++;
    }
  }
  Console.WriteLine($"s: {s}");
}его решение */ 
string[] fnames = {"Ivan", "Sergey"};
string[] lnames = {"Ivanov", "Sergeev"};

for (int i=1; i<= 10; i++)

{
    int ni = Random.Shared.Next(fnames.Length);
    int fi = Random.Shared.Next(lnames.Length);
    File.AppendAllText("db1.csv", $"{i}; {fnames[ni]}; {lnames[fi]}; {Random.Shared.Next(10, 33)}\n");
}