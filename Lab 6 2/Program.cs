using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;

            int xn = 3, xk = 4;   

            double e; 

            double y = 0;

            int i = 0;

           
            Console.Title = " Вычисление квадратного корня";
           
            Console.Write("Введите значение точности e: ");
            String str = Console.ReadLine();
            e = Convert.ToDouble(str);
            x = xn;
            do
            {
                y = Math.Pow(x, 3) - 2 * Math.Pow(x, 2) - 4 * x - 7;
                if (x + e <= xk)
                {
                    x = x + e;
                }
                i++;
            } while (y <= 0);


            Console.WriteLine("Корнем уравнения будет x = {0:2}, к-во итераций: {1}", x , i);

            Console.Write("Для завершения работы приложения нажмите <Enter>");
            Console.Read();

        }
    }
}


/*
Console.Title = "Оператор do while";

            double xn = 3, xk = 4;
double y = 0;
double e;
double x;
int count = 0;

Console.Write("Введите точность: ");
            String str = Console.ReadLine();
e = Convert.ToDouble(str);
            x = xn;
            do
            {
                    y = Math.Pow(x, 3) - 2 * Math.Pow(x, 2) - 4 * x - 7;
                if (x + e <= xk)
                {
                    x = x + e;
                }
                    count++;
            } while (y <= 0);

            Console.WriteLine("Решение уравнения будет x= {0}, к-во итераций: {1}",x,count);
            Console.ReadKey();

    */