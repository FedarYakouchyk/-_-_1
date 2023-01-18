Console.Write("Введите любое целое число");
int Num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= Num; i++) // так как "0" тоже является чётным числом, а в условии все примеры начинались с "2" переменной "i" присваивалась единица
{
    int Ost = i%2;
    if (Ost==0)
{
  Console.Write($"{i}, ");  
}
}
