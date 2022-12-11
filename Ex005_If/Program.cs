// See https://aka.ms/new-console-template for more information
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же Маша!!!");
}
else
{
    Console.Write ("Привет");
    Console.WriteLine(username);
}