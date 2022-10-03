Console.WriteLine("Пожалуйста представьтесь (имя пользователя)");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Привет, тварь!");
}
else
{
    Console.WriteLine($"добрый вечер {username}");
}