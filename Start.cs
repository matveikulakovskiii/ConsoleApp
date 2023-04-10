using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Start
    {
        public static void Main()
        {
            string p=0
            while (p=1) 
            {
                Console.WriteLine("Oosta elevanti");
            }
            

            /*Console.WriteLine("Tere tulemast!\nMis on sinu nimi?");
            string eesnimi1 = Console.ReadLine();
            Console.WriteLine("Mis on naabri nimi?");
            string eesnimi2 = Console.ReadLine();
            if (eesnimi1!= eesnimi2) 
            {
                Console.WriteLine(eesnimi1 + " " + "ja" + " " + eesnimi2 + " " + "on täna pinginaabrid");
            }
            else
            {
                Console.WriteLine(eesnimi1 + " " + "ja" + " " + eesnimi2 + " " + "ei ole täna pinginaabrid");
            }*/
            /*Random rnd = new Random();
            int N = rnd.Next(-100, 100);
            int M = rnd.Next(-100, 100);
            int pikkus = 0;
            if (N<0 && M < 0) 
            { 
                if(N < M)
                {
                    pikkus = Math.Abs(N) - Math.Abs(M);
                }
                else
                {
                    pikkus = Math.Abs(M) - Math.Abs(N);
                }
            }
            else if (N<0 && M>0) 
            {
                pikkus = Math.Abs(N) + M;
            }
            else if (M<0 && N>0) 
            {
                pikkus = Math.Abs(M) + N;
            }
            else
            {
                if (M>N) 
                {
                    pikkus = M - N;
                }
                else 
                { 
                    
                }
            }*/
            /*string paev = "";
            for (int i = 0; i < 10; i++)
            {
                int nr = rnd.Next(1, 7);
                Console.WriteLine(nr);
                switch (nr)
                {
                    case 1: paev = "Esmaspäev"; break;
                    case 2: paev = "Teisipäev"; break;
                    case 3: paev = "Kolmapäev"; break;
                    case 4: paev = "Neljapäev"; break;
                    case 5: paev = "Reede"; break;
                    case 6: paev = "Laupäev"; break;
                    case 7: paev = "Pühapäev"; break;
                    default:
                        paev = "Tundmatu päev";
                        break;
                }
                Console.WriteLine(paev);
            }
            int j = 0;
            while (j<10)
            {
                Console.WriteLine(paev);
                j++;
            }
            Console.WriteLine(j);
            do
            {
                Console.WriteLine(paev);
                j--;
            } while (j!=0);
            Console.WriteLine(j);
            int[] arvud = new int[10];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(-100, 100);
            }
            foreach (int arv in arvud)
            {
                if (arv < 0) 
                {
                    Console.Beep();
                }
                Console.WriteLine(arv);
            }*/
            /*if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("siis lähme kinno!");
                Console.WriteLine("Kui palju aastat sul on?");
                char aasta = char.Parse(Console.ReadLine());
                if (aasta < 6)
                {
                    Console.WriteLine("Jukus on tasuta");
                }
                else if (aasta <= 14)
                {
                    Console.WriteLine("Jukus on lastepilet");
                }
                else if (aasta <= 65)
                {
                    Console.WriteLine("Jukus on täispilet");
                }
                else if (aasta >= 65)
                {
                    Console.WriteLine("Jukus on sooduspilet");
                }
                else if (aasta >= 100)
                {
                    Console.WriteLine("viga andmetega");
                }
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole!");
            }*/
            /*Console.WriteLine("Tere" + ' ' + eesnimi);
            Console.WriteLine("Sisesta esimene arv");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tehe: ");
            char tehe = char.Parse(Console.ReadLine());
            while (true)
            {
                if (tehe == '+')
                {
                    Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 + arv2);
                    break;
                }
                else if (tehe == '-')
                {
                    Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}", arv1, arv2, arv1 - arv2);
                    break;
                }
                else
                {
                    Console.WriteLine("Erorr");
                    break;
                }


            }*/
        }   
    }
}
