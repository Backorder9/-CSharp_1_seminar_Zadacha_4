// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите первое целое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int num3 = int.Parse(Console.ReadLine());
int max = 0;
if (num1 > max)
{    
    max = num1;
}
if (num2 > max)
{    
    max = num2;
}
if (num3 > max)
{    
    max = num3;
}
Console.WriteLine($"Из трёх введённых чисел {num1}, {num2} и {num3} наибольшим числом является число {max}.");