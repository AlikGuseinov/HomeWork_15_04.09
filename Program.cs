Console.Write("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a==6 || a==7)
{
    Console.WriteLine("Это выходной, можешь отдыхать)");
}
else
{
    Console.WriteLine("Это не выходной, работай!");
}
