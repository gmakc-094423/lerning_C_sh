Console.Write("Введи число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = -numberA;

while (numberB < numberA)
{
  Console.Write(numberB + ", ");
  numberB+=1;
}
Console.WriteLine(numberA);

// задача 2 - из трехзначного числа последнюю цифру

Console.Write("Введи трёхзначное число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int numberD = numberC % 10;

Console.WriteLine("Последнее число: " + numberD);

