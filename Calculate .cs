using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Practical21
{
    internal class Calculate
    {
        public int realnumber;
        public int notrealnumber;

        public Calculate()
        {
            realnumber = 0;
            notrealnumber = 0;
        }

        public Calculate(int real)
        {
            realnumber = real;
            notrealnumber = 0;
        }

        public Calculate(int real, int notreal) : this(real)
        { 
            realnumber = real;
            notrealnumber = notreal;
        }
        public double SquareRoot()
        {
            return Math.Sqrt(realnumber * notrealnumber);
        }
        public override string ToString() 
        {
            return $"Вещественное число: {realnumber}, не вещественное число: {notrealnumber}, квадратный корень: {SquareRoot()}";
        }
    }
}
