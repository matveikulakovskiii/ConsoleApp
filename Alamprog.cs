using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Alamprog
    {
        public static int Korruta(int arv1, int arv2) 
        {
            return arv1 * arv2;
        }
        public static double Average(int k)
        {
            
            int[] vast = new int[k];
            
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"Kirjuta numbrid {i + 1}: ");
                vast[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (int item in vast)
            {
                sum += item;
            }
            double avr = (double)sum / vast.Length;
            return avr;
        }



        public static void Tere(string name) 
        {
            Console.WriteLine("Tere {0}", name);
        }
    }
}
