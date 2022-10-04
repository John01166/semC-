
Console.WriteLine("Введите два целых числа");
Console.WriteLine("Первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if (num2>max) max = num2;
Console.Write("max = ");
Console.WriteLine(max);