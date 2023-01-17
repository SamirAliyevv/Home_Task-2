using System;

namespace Verilmis_n_tam_ededini_reqemleri_cemin_tapan_proqram
{
    internal class Program
    {
        static int DigitSum()
        {
            int number = 2345;
            int sum = 0;
            int digit = 0;
            while (number > 0)
            {
                digit = number % 10;
                number /= 10;
                sum += digit;

            }

           



            return sum;



        }
        static void Main(string[] args)
        {
            Console.WriteLine(DigitSum());
            
        } 


    }
}
