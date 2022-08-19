// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine ("Введите первое любое целое число :");
int a = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе любое целое число :");
int b = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите третье любое целое число :");
int c = int.Parse(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}
Console.Write("Самое большое число это ");
Console.Write(max);
