int number = new Random().Next(100,999);
Console.Write("Изначальное число: ");
Console.WriteLine(number);
int first = (number % 100) / 10;
Console.Write("Конечное число: ");
Console.WriteLine(first);