using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Start
    {
        public static void Main(string[] args)
        {
            /*try
            {
                StreamWriter text = new StreamWriter(@"..\..\..\TextFile.txt", true);
                string lause = "Lisan failisse lause\n";
                text.WriteLine(lause);
                text.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
            try
            {
                StringReader text = new StringReader(@"..\..\..\TextFile.txt");
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine("Failise on järgmine informatsion:\n");
                Console.WriteLine(laused);

            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }*/

            Dictionary<string, string> riigid = new Dictionary<string, string>(4);
            riigid.Add("Harjumaa", "Tallinn");
            riigid.Add("Pärnumaa", "Pärnu");
            riigid.Add("Tartumaa", "Tartu");
            riigid.Add("Ida-Virumaa", "Narva");

            foreach (KeyValuePair<string, string> keyValue in riigid)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            int p = 0;
            while (true)
            {
                Console.WriteLine("1 - Uznat linn või maakond\n 2 - dobavit\n 3 - Mäng");
                int valik0 = int.Parse(Console.ReadLine());
                if (valik0 == 1)
                {
                    try
                    {
                        Console.WriteLine("maakond või linn: ");
                        string valik = Console.ReadLine();
                        if (valik.ToLower() == "maakond")
                        {
                            Console.WriteLine("Kirjuta maakond: ");
                            string valik2 = Console.ReadLine();
                            foreach (KeyValuePair<string, string> keyValue in riigid)
                            {
                                if (valik2 == keyValue.Key)
                                {
                                    string country = keyValue.Value;
                                    Console.WriteLine(country);
                                }
                            }
                        }
                        else if (valik.ToLower() == "linn")
                        {
                            Console.WriteLine("Kirjuta linn: ");
                            string valik2 = Console.ReadLine();
                            foreach (KeyValuePair<string, string> keyValue in riigid)
                            {
                                if (valik2 == keyValue.Value)
                                {
                                    string country = keyValue.Key;
                                    Console.WriteLine(country);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Viga!");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Viga!");
                    }
                }
                else if (valik0 == 2)
                {
                    Console.WriteLine("Kirjuta Maakond");
                    string val = Console.ReadLine();
                    Console.WriteLine("Kirjuta Linn");
                    string val1 = Console.ReadLine();
                    riigid.Add(val, val1);
                    foreach (KeyValuePair<string, string> keyValue in riigid)
                    {
                        Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                    }
                }
                else if (valik0 == 3)
                {
                    foreach (KeyValuePair<string, string> keyValue in riigid)
                    {
                        int vast = 0;
                        Console.WriteLine(keyValue.Key);
                        string vastus = Console.ReadLine();
                        if (vastus == keyValue.Value)
                        {
                            Console.WriteLine("Õige");
                            vast++;
                        }
                        else if (vastus != keyValue.Value)
                        {
                            Console.WriteLine("Vale");
                        }
                        Console.WriteLine("Sul on " + vast / vast * 100 + " %");
                        
                    }
                }
                else
                {
                    Console.WriteLine("Hüvasti");
                    break;
                }
            }
            /*ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            do 
            {
                Console.WriteLine("Vajuta Backspace");
                nupp=Console.ReadKey();
            }while (nupp.Key != ConsoleKey.Backspace);*/
            /*Dictionary<int,string> dic = new Dictionary<int, string>(5);
            dic.Add(1, "Üks");
            dic.Add(2, "Kaks");
            dic[3] = "Kolm";
            dic[4] = "Neli";
            dic[5] = "Viis";
            foreach (KeyValuePair<int,string> keyValue in dic)
            {
                Console.WriteLine(keyValue.Key + "-" + keyValue.Value);
            }

            Dictionary<int,Inimene> opilased = new Dictionary<int,Inimene>(3);
            Inimene inimene = new Inimene();
            inimene.Nimi = "Matvei";
            inimene.Vanus = 16;
            Inimene inimene2 = new Inimene();
            inimene2.Nimi = "Anna";
            inimene2.Vanus = 17;
            opilased.Add(1, inimene);
            opilased.Add(2, inimene2);
            opilased.Add(3,new Inimene() { Nimi = "Sahsa", Vanus = 16 });
            foreach (Inimene item in opilased.Values)
            {
                Console.WriteLine(item.Nimi);
            }
            foreach (KeyValuePair<int, Inimene> item in opilased)
            {
                Console.WriteLine(item.Key + ": " + item.Value.Nimi);
            }*/
            /*List<Inimene> list = new List<Inimene>();
            Inimene inimene = new Inimene();
            inimene.Nimi = "Matvei";
            inimene.Vanus = 16;
            list.Add(inimene);
            list.Add(new Inimene() { Nimi = "Anna" });
            foreach (Inimene item in list)
            {
                Console.WriteLine(item.Nimi);
            }*/
            /*ArrayList arrayList = new ArrayList();
            arrayList.Add("Esimene");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");
            if (arrayList.Contains("Teine")) 
            {
                Console.WriteLine("Sõna Teine on olemas");
                Console.WriteLine("Teine asub kohal" + arrayList.IndexOf("Teine"));
            }
            else 
            {
                Console.WriteLine("Otsitav sõna puudub");
            }
            Console.WriteLine("Koku järjendis on " + arrayList.Count + "elemente");
            arrayList.Insert(3, "Neljas");
            arrayList.Insert(4, "Viies");
            arrayList.Sort();
            foreach (string item in arrayList)
            {
                Console.Write(item + ", ");
            }
            arrayList.RemoveAT(0);
            arrayList.Remove("Viies");
            arrayList.Clear();*/
            /*for (int g = 0; g < f; g++)
            {
                Console.WriteLine("\nKirjuta number: ");
                int aft = int.Parse(Console.ReadLine());
                for (int i = 0; i < aft; i++)
                {
                    Console.Write("*" + " ");
                }
                return aft;
            }*/
            /*string nimi = "Python";
            Alamprog.Tere(nimi);
            int a = 12;
            int b = 13;
            int vastus = Alamprog.Korruta(a, b);
            Console.WriteLine(vastus);
            Console.WriteLine(Alamprog.Korruta(6,7));
            Console.WriteLine("Kui palju numbreid? ");
            int vat = int.Parse(Console.ReadLine());
            Console.WriteLine(Alamprog.Average(vat));*/
            /*while (true) 
            {
                Console.WriteLine("Osta elevant ära!");
                string valik = Console.ReadLine();
                if (valik.ToLower() == "elevant") 
                {
                    break;
                }     
            }*/
            /*Console.WriteLine("kirjutage üles suvalised 4 neljakohalist numbrit");
            int nbr1 = int.Parse(Console.ReadLine());
            int nbr2 = int.Parse(Console.ReadLine());
            int nbr3 = int.Parse(Console.ReadLine());
            int nbr4 = int.Parse(Console.ReadLine());

            int largo = Math.Max(Math.Max(Math.Max(nbr1, nbr2), nbr3), nbr4);
            if (largo >=1000 && largo <= 9999) 
            {
                Console.WriteLine("suurim 4-kohaline arv on: {0}",largo);
            }
            else 
            {
                Console.WriteLine("Neljakohalisi numbreid pole");
            }*/
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
