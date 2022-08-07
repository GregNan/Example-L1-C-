//с клавиатуры считывается массив чисел через запятую
// в виде 1,3,4,5,6,7,8,3,4

// Получить новый массив, в котором будут квадраты четных чисел
//16,36,64,16
// нельзя использовать split
//Идеально - если будет алгоритм (БС) основного действия

/*string s_global; 
string leng;
int[] array = new int[10];

void get_array()
{
    Console.WriteLine("vvedite massiv:");
    string s = Convert.ToInt32(Console.Readline());
    leng = s.Length;
    s_global=s;
}

void incept_array(string s)

{
    int i=0;
    int j=0;
    while (i< leng)
    {
        array[j]= Convert.ToInt32(s_global[i].ToString());
        for (int k=0; k<leng; k++)
        {
            if (array[j] ==',')
            {
                array[i]
            }
        }
        Console.WriteLine("array="+array[j]);
        j=j++;

    }
    make_kvadrat();

}
void make_kvadrat()
{
    int a;
    for (i=0; i<10; i++)
    {
        array[i]=array[i]*array[i];
        Console.Writeline("izmenen massiv");
        Console.Writeline(array[i]);
    }
}

get_array();
incept_array(s_global);
*/
/*string s = "123";
Console.WriteLine(4+ Convert.ToInt32(s[0].ToString()));
Console.WriteLine(Convert.ToInt32(' '));
Console.WriteLine(s[0]);*/

//1 считывание
//10преобразование
//3 получение квадратов
//++67 вывод
//узнать сколько четных
// узнать сколько до запятой- это и будет первое число
// найти запятую, скопировать до 

void Print(int[] array)
{
    int size = array.Length;
    for (int i=0; i < size; i++)
    {
        Console.Write($"{array[i]}");
    }
System.Console.WriteLine();
}
string GetData(string title)
{
    Console.Write(title);
    return Console.ReadLine();
}
/*string str = GetData ("vvedite chisla");*/

int[] MainEx(int[] array)
{
    int size = array.Length;
    int isEvenCount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            isEvenCount++;
        }
    }

    int[] result = new int[isEvenCount];
    int index = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            result[index] = array[i]*array[i];
            index++;
        }
    }
    
      
    
    return result;
}

int CountSynbol(string s, char c)
{
    int count = 0;
    int length = s.Length;
    for (int i = 0; i < length; i++)
    {
        if (s[i] == c) count++;
    }
    return count;

}

int IndexOf(string s, char c)
{
    int length = s.Length;
    int pos = -1;
    for (int i = 0; i <length; i++)
    {
        if (s[i] == c)
        {
            pos =i;
            break;
        }
    }
    return pos;
}

string Substring(string s, int position, int length)
{
    string res = String.Empty;
    int size = s.Length;
    for (int i = position; i < position + length; i++)
    {
        res += $"{s[i]}";
    }
    return res;

}

int[] Parse(string s)
{
    int[] result = new int[CountSynbol(s, ',')+1];
    s+= ',';

    int index = 0;
    while (s.Length != 0)
    {
        int posSeparator = IndexOf(s, ',');
        System.Console.WriteLine($"pos{posSeparator}");
        string need = Substring(s, 0, posSeparator);
        System.Console.WriteLine($"need = {need}");
        string o = Substring(s, 0, posSeparator + 1);
        System.Console.WriteLine($"o = {o}");
        Console.ReadLine();
        s = o;
        result[index] = Convert.ToInt32(need);
        index++;


    }
    return result;
}
//Console.WriteLine(
//IndexOf("143,243,3343,443,5434,643,71,8342",','));


/*int[] inArr = {1, 4, 6 };
Print(inArr);
int[] outArr = MainEx(inArr);
Print(outArr);*/
string s = "143,243,3343,443,5434,643,71,8342";
System.Console.WriteLine(s);

string str = GetData ("vvedite ch cherez zapytuy");
int[] inArr = Parse(str);
Print(inArr);
int[] outArr = MainEx(inArr);
Print(outArr);
File.WriteAllText("out.txt", so);


/*Parse(s);
Console.WriteLine(
    //Substring(s, 5)
    Substring(s, 0, 3)

);*/
    




