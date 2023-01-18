Console.Write("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{ 
   Console.WriteLine($"Число {a} больше чем число {b}"); 
}
else
{
   Console.WriteLine($"Число {b} больше чем число {a}"); 
}