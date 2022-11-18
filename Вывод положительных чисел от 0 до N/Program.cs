    //Определение и вывод положительных чисел до числа N, введенного пользователем
    Console.WriteLine ("Введите число: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int number = 0;
    int number1 = 0;
    if (N < 0)
    {
        Console.WriteLine("Введите положительное число ");
    }             
    else
    {  
        while (number <= N)
        {
            if (number%2 == 0)
            number1 = number;
            Console.WriteLine(number1);
            number = number + 2;
        }
    }