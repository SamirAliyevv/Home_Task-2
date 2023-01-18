using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Qeyd_olunan_yazida_A_herfinin_olub_olmamasi
{
    internal class Program
    {
        static string Aherfiolmasi(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                
                  if (word[i] == 'a')
                  {
                     count++;
                   
                    break;
                    
                  }
            }

            if (count>0)
            {
                return " A herfi movcuddur";
            }
            else
            {
                return "A herfi movcud deyil";
            }

            
        }  
        


        static void Main(string[] args)
        {
            //Qeyd olunan yazida A herfinin olub olmamasi 
            Console.WriteLine("Zehmet olmasa yazini qeyd edin");
            String word=Convert.ToString(Console.ReadLine());
            var result = Aherfiolmasi(word);
            Console.WriteLine(result);
            
            
           
           
 
        }
    }
}
