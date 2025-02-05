using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Practical21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate(4, 5); //явная инициализация
            Console.WriteLine(calculate);

            Calculate calculate1 = new Calculate();//Два параметра
            {
                calculate1.realnumber = 4;
                calculate1.notrealnumber = 5;
            }

            Console.WriteLine("Введите  число: ");
            int real = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            int otreal = Convert.ToInt32(Console.ReadLine());
            Calculate calculate2 = new Calculate(real, otreal); //в ручную
            Console.WriteLine(calculate2);
        }
    }
}
