Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max;
if(numberA > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}
Console.WriteLine(max);