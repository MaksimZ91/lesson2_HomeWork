
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//-- Первый вариант решения --


// void FindeNumber ()
// {
//   Console.Write("Введите  число: ");
//   int number = Convert.ToInt32(Console.ReadLine());
//   while(number >= 1000 || number < 100)
//   {
//     Console.Write("Введите число: ");
//     number = Convert.ToInt32(Console.ReadLine());  
//   }
//   Console.Write((number % 100) / 10);
// }


//-- Второй вариант решения --

// void FindeNumber ()
// {
//   Console.Write("Введите  число: ");
//   string number = Console.ReadLine();
//   while(number.Length > 3 || number.Length < 3)
//   {
//     Console.Write("Введите число: ");
//     number = Console.ReadLine();  
//   }
//   Console.Write(number[1]);
// }

// FindeNumber();


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//-- Первый вариант решения --

// void FindThirdNubmer ()
// {
//   Console.Write("Введите  число: ");  
//   int number = Convert.ToInt32(Console.ReadLine());
//   if (number < 100)
//     Console.Write("Третьей цифры нет");
//   else
//   { 
//   while (number > 1000)
//     {
//       number = number / 10;
//     }
//   Console.Write(number % 10);
//   }
// }


//-- Второй вариант решения --

// void FindThirdNubmer ()
// {
//   Console.Write("Введите  число: ");  
//   string number = Console.ReadLine();
//   if (number.Length < 3)
//     Console.Write("Третьей цифры нет");
//   else
//   Console.Write(number[2]);  
// }

// FindThirdNubmer ();

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// void FindeDay()
// {
//   Console.Write("Введите  число: ");  
//   int number = Convert.ToInt32(Console.ReadLine());
//   while(number > 7 || number < 1)
//   {
//     Console.Write("Введите число: ");
//     number = Convert.ToInt32(Console.ReadLine());
//   }
//   string[] array = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
//   int sunday = 6;
//   int saturday = 5;
//   if (number-1 == saturday || number-1 == sunday )
//     Console.Write(array[number-1] + " выходной день =)");
//   else
//     Console.Write(array[number-1] + " рабочий день =(");
// }

// FindeDay();


//Дополнительная задача
  
// int[] array = {97,89,6,8,64,9,0,32,99};

//  int FindSecondMax(int[]array)
//  {
//     int maxIndex = 0;
//     int secondMaxIndex = 1;
//     for (int i = 0; i < array.Length-1; i++)
//     {
//       if (array[maxIndex] < array[i+1])
//       {
//         int buff = maxIndex;
//         maxIndex = i+1;
//         secondMaxIndex = buff;
//       }
//       else if(array[secondMaxIndex] < array[i+1])
//       secondMaxIndex = i+1;
//     }
//     return array[secondMaxIndex];
//  }

//  Console.Write(FindSecondMax(array));