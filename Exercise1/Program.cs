// Даны два числа. Показать большее и меньшее число.

int numberA = new Random().Next(1,100);
int numberB = new Random().Next(1,100);
Console.WriteLine("Первое число: " + numberA);
Console.WriteLine("Второе число: " + numberB);
if (numberA == numberB)
    {Console.WriteLine ("Числа равны");};
if (numberA > numberB)
    {Console.WriteLine("Большее число - " + numberA + "; " + "Меньшее число - " + numberB);}
else {Console.WriteLine("Большее число - " + numberB + "; " + "Меньшее число - " + numberA);};
    
