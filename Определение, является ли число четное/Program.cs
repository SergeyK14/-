﻿    //Определение, является ли введенное число четным
    Console.WriteLine ("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number%2 == 0)
    {
        Console.WriteLine("Число является четным");
    }
    else {Console.WriteLine("Число является нечетным");}