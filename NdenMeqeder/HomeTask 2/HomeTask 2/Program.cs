using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using System.Threading;

namespace HomeTask_2
{
    internal class Program
    {

        static int NdenMe(int n, int m)
        {

            int sum = 0;
            int count = 0;

            if (n < m)
            {

                for (int i = n; i < m; i++)
                {
                    if (i % 21 == 0)
                    {
                        sum += i;
                        count++;

                    }



                }

            }


            return sum / count;






        }

        static void Main(string[] args)
        {
            //N den M e qeder 21 e bolunen ededlerin ededi ortasini tapan proqram

            Console.WriteLine("Zehmet olmasa ededleri daxil edin");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NdenMe(n, m));


        }
    }
    

   
    


    
}
