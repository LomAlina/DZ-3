// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(number);

if (stringNumber [0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
{
    Console.WriteLine($"Число {number} - палиндром.");
  }
  else Console.WriteLine($"Число {number} - не палиндром.");