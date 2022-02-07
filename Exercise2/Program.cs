// Найти максимальное из трех чисел
Console.Write("Введите 1-ое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max) {max = numberB;};
if (numberC > max) {max = numberC;};
Console.WriteLine(max);
