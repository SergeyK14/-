// Ввод двух чисел и нахождение максbмального из них
Console.WriteLine ("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
{
    max = number2;
} 
if (number3 > max)
        {
            Console.WriteLine("Максимальное число равно " + number3);
        }
else {Console.WriteLine("Максимальное число равно " + max);}