using System;

namespace Lesson3_05._06._2020
{
    class Program
    {
        static void Main(string[] args)
        {
      {
          // Задача 2
          Console.Write("Введите значение A : ");
      int A=int.Parse(Console.ReadLine());
       Console.Write("Введите значение B : ");
       int B=int.Parse(Console.ReadLine());
          if(A==B)
          {
              A=0;
              B=0;
          }
          else if(A>B)
          {
              B=A;
              A=B;
          }
          else 
          {
              A=B;
              B=A;
          }
          Console.WriteLine($"Результат значение A : {A}");
          Console.WriteLine($"Результат значение B : {A}");
      } 
    {
        //Задача 3
        Console.WriteLine();
          Console.Write("Введите значение operand1 : ");
    double operand1=double.Parse(Console.ReadLine());
          Console.Write("Введите значение operand2 : ");
    double operand2=double.Parse(Console.ReadLine());
          Console.Write("Арифметическая операция : ");
    string sign=Console.ReadLine();
    switch(sign)
     {
     case "+":Console.WriteLine($"Результат operand1+operand2 = {operand1+operand2}");break;
     case "-": Console.WriteLine($"Результат operand1-operand2 = {operand1-operand2}");break;
     case "*": Console.WriteLine($"Результат operand1*operand2 = {operand1+operand2}");break;
     case "/":
     {
         if(operand2==0) Console.WriteLine("На ноль делить нельзя");
        else Console.WriteLine($"Результат operand1:operand2 = {operand1/operand2}");break;
     }
     default: Console.WriteLine("Неправильно введенные данные!");break;
     }
     }
     {
     // Задача 4
     Console.WriteLine();
           Console.Write("Введите число :");
     double num=double.Parse(Console.ReadLine());
     if(num>=0 && num<=100)
     {
    Console.Write("Ваше число входит в промежуток ");
    if(num>=50)Console.WriteLine("[50-100]");
    else if(num>=36)Console.WriteLine("[36-50]");
    else if(num>=15)Console.WriteLine("[15-35]");
    else Console.WriteLine("[0-14]");
     }
     else Console.WriteLine("Ваше число не входит не в одном промежуток!");
   }
    }
 }   
} 