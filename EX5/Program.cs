// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
    {
        Console.Write("Ура, это же Маша");
    }
    else{
        Console.Write("Привет ");
        Console.Write(username);
    }
    
