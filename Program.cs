using System;

namespace Lesson3_05._06._2020
{
    class Program
    {
        static void Main(string[] args)
        {
      // Задача 2
      int A=int.Parse(Console.ReadLine());
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
          Console.WriteLine($" {A}  {B} ");
        
     /*Задача 3   
    double operand1=double.Parse(Console.ReadLine());
    double operand2=double.Parse(Console.ReadLine());
    string sign=Console.ReadLine();
    switch(sign)
     {
     case "+":Console.WriteLine(operand1+operand2);break;
     case "-": Console.WriteLine(operand1-operand2);break;
     case "*": Console.WriteLine(operand1*operand2);break;
     case "/":
     {
         if(operand2==0) Console.WriteLine("На ноль делить нельзя");
        else Console.WriteLine(operand1/operand2);
     }break;
     */
     /* Задача 4
     double N=double.Parse(Console.ReadLine());
     if(N>=0 && N<=14)Console.WriteLine("[0-14]");
     else if(N>=15 && N<=35)Console.WriteLine("[15-35]");
      else if(N>=36 && N<=50)Console.WriteLine("[36-50]");
     else Console.WriteLine("[50-100]");
    */
     }
     
    }
  }

