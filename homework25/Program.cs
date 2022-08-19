Console.WriteLine("Введите число А ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < number2; i++)
{
    result = result * number1;
}
Console.WriteLine("Число А в степени В = ");
Console.WriteLine(result);