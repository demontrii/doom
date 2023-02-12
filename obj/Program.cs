// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Первое число " + num1 + " больше чем второе " + num2);
}
else
{
    Console.WriteLine("Второе число " + num2 + " больше чем первое " + num1);
}

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Введите 3 числа:");
int num_a = Convert.ToInt32(Console.ReadLine());
int num_b = Convert.ToInt32(Console.ReadLine());
int num_c = Convert.ToInt32(Console.ReadLine());

int max = num_a;

if (num_b > max)
{
    max = num_b;
}

if (num_c > max)
{
    max = num_c;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Введите число:");
int num_1 = Convert.ToInt32(Console.ReadLine());

if (num_1 % 2 == 1)
{
    Console.WriteLine("Число " + num_1 + " является: НЕЧЁТНЫМ");
}
else
{
    Console.WriteLine("Число " + num_1 + "является: ЧЁТНЫМ");
}

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Чётные числа от 1 до " + num);
 while (i <= num)
 {
     if (i % 2 != 1)
    {
        Console.Write(i + ", ");
         not = false;
    }
        i++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}

