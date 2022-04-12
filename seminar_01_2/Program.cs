Console.Write("Введи число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA < 0)   // проверка на отрицательное чисто
{
 numberA = -numberA;
}

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

Console.WriteLine("Последняя цифра: " + numberD);





// if (numberA < 0) 
// {
//  numberA = -numberA
//}