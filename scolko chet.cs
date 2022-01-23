using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint number1 = 0; //нечет.
            uint number2 = 0; //чет

            Console.WriteLine("ведите первое число диапозона");
            int value = int.Parse(Console.ReadLine()); //ввод числа
            Console.WriteLine("ведите второе число диапозона");
            int limit= int.Parse(Console.ReadLine()); //до какого числа

            while(value <= limit)
            {
                if(value % 2 == 0){

                    //взятие остатка от деления на два и если равен нулю то это четное
                    number2++; //+1 к чет
                }
                else
                {
                    number1++;//+1 к нечет
                }
                value++;
            }

            Console.WriteLine("Количество нечетных чисел " + number1);
            Console.WriteLine("Количество четных чисел " + number2);
            Console.ReadLine();// чтобы exe не закрывалось
        }
    }
}

