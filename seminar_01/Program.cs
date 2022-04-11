Console.Write("Введи первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int square = numberA * numberA;

if (square == numberB)
{
Console.Write("Да");
}
else 
{
Console.WriteLine("Нет");
}


Console.WriteLine("Введи число дня недели: ");
int numberС = Convert.ToInt32(Console.ReadLine());

if (numberС == 1)
{
  Console.Write("Понедельник");
}

else 
{
if (numberС == 2)
{
  Console.Write("Вторник");
}

else 
{
if (numberС == 3)
{
  Console.Write("Среда");
}

else 
{
if (numberС == 4)
{
  Console.Write("Четверг");
}

else 
{
if (numberС == 5)
{
  Console.Write("Пятница");
}

else 
{
if (numberС == 6)
{
  Console.Write("Суббота");
}

else 
{
if (numberС == 7)
{
  Console.Write("Воскресенье");
}
}
}
}
}
}
}