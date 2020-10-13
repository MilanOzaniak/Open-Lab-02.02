using System;
using System.Globalization;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
           for (int i = 0; i < 5; i++)
            {
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalSeparator = ".";
                double numbersdecimal = numbers[i];
                numbersdecimal = Math.Round(numbersdecimal, 2);
                Console.Write(numbersdecimal.ToString(nfi));
                if (i < 4) Console.Write(" ");

            }
        }
    }
}
