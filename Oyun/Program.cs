using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] rastgelesayilar = new int[5];

            for(int i = 0; i < rastgelesayilar.Length; i++)
            {
                rastgelesayilar[i] = random.Next(1,10); 
            }
            int puan1 = 0;
            int puan2 = 0;
            for (int i = 0; i < rastgelesayilar.Length; i++)
            {
                Console.WriteLine("1.Oyuncu Tahmini: ");
                int tahmin1 = Convert.ToInt32(Console.ReadLine());
                if (tahmin1 == rastgelesayilar[i])
                {
                    puan1 += 10;
                }
                else
                {
                    if (rastgelesayilar[i] > tahmin1)
                    {
                        puan1 += 10 - (rastgelesayilar[i] - tahmin1);
                    }
                    else
                    {
                        puan1 += 10 - (tahmin1 - rastgelesayilar[i]);
                    }
                }
                Console.Clear();
                //-------------- 2.oyuncu başlangıç-------------
                Console.WriteLine("2.Oyunvu Tahmini: ");
                int tahmin2 = Convert.ToInt32(Console.ReadLine());
                if (tahmin2 == rastgelesayilar[i])
                {
                    puan2 += 10;
                }
                else
                {
                    if (rastgelesayilar[i] > tahmin2)
                    {
                        puan2 += 10 - (rastgelesayilar[i] - tahmin2);
                    }
                    else
                    {
                        puan2 += 10 - (tahmin2 - rastgelesayilar[i]);
                    }
                }
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1.Oyuncunun Puanı:" + puan1);
            Console.WriteLine("2.Oyuncunun Puanı:" + puan2);
            Console.WriteLine("-------------------------------");
            Console.ReadKey();

        }
    }
          
}



