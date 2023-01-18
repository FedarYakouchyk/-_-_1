Console.Write("Введите любое целое число");
int Num = Convert.ToInt32(Console.ReadLine());
int Ost = Num%2;
if (Ost==0)
{
  Console.WriteLine($"Число:{Num} является чётным");  
}
else
{
   Console.WriteLine($"Число:{Num} является нечётным"); 
}