Console.Write("Ввести имя пользователя: ");
string userName = Console.ReadLine();

if (userName == "Маша")
{
  Console.WriteLine("Да ты же Маша!, привет!");
}
else 
{
  Console.WriteLine("Ты не Маша :( . Но всё равно привет, " + userName);
}