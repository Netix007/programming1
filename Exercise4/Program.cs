// Показать четные числа от 1 до N

Console.Write("Введите число N (N - целое число, больше 1) ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа от 1 до " + N + ":");
for (int i = 1; i<= N; i++) {
    if (i % 2 == 0) {Console.Write(i + "; ");};
};

