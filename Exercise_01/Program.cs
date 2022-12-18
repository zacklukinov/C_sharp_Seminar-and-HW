// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2)
{
    Console.WriteLine("Первое число больше второго");
}
if (num_2 > num_1)
{
    Console.WriteLine("Второе число больше первого");
}
if (num_1 == num_2)
{
    Console.WriteLine("Оба числа равны");
}
