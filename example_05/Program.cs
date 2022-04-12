Console.Write("Ввести имя пользователя: ");
string? userNameNew = Console.ReadLine();

if (userNameNew == "маша")
{
  Console.WriteLine("Да ты же Маша!, привет!");
}
else 
{
  Console.WriteLine("Ты не Маша :( . Но всё равно привет, " + userNameNew);
}