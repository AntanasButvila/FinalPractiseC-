﻿// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

// Console.WriteLine("Ведите значение М: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     if(start < 0 || end < 0)
   
//    return ("Вы ввели не натуральное число!!! Попробуйте снова.").ToString();
       
    
//     if(start == end) return start.ToString();

//     return (start + ", " + PrintNumbers(start +1, end));
// }
// Console.WriteLine(PrintNumbers(M,N));



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Ведите значение М: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());

//  if(M < 0 || N < 0)
//  {
//     Console.WriteLine("Вы ввели не натуральное число!!! Попробуйте снова.");
//     return;
//  }
//  if(M > N)
//  {
//     Console.WriteLine($"Значение '{M}' Превышает значение '{N}' и не соответствует условиям задачи. Попробуйте снова.");
//     return;
//  }
       
//    int PrintSumNumbers(int start, int end)
// {
    
//     if (start == end) return start;
   
//     return (PrintSumNumbers(start + 1, end) + start);

// }

// Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна: {PrintSumNumbers(M,N)}");