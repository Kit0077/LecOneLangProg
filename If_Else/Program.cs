Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это МОШИНА");
}
else
{
    Console.Write("А, это ты, привет ");
    Console.Write(username);
}
