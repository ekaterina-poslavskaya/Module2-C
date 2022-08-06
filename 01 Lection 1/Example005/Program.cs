Console.WriteLine("Введите имя пользователя");
string un = Console.ReadLine();
if (un.ToLower()=="Маша")
{Console.WriteLine("Привет, Маша");}
else
{Console.Write("Привет,");
Console.WriteLine(un);}