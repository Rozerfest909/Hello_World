Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "катя")
{
    Console.WriteLine("Ура! Это же Катя");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}