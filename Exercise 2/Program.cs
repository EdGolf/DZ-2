int numberA = 127;
int numberB = (numberA % 100) / 10;


  if(numberA > 100)
  {
    Console.Write("Изначальное число: "); 
    Console.WriteLine(numberA);
    Console.Write("Конечное число: ");
    Console.WriteLine(numberB);

  }
  else
  {
    Console.Write("Изначальное число: ");
    Console.WriteLine(numberA);
    Console.Write("Третьей цифры нет"); 
  }