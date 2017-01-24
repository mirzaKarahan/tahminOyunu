using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramlamaDers
{
    class Program
    {
        static void Main(string[] args)
        {          
          int tahmin;
            int adim = 1;
            int min = 0;
            int max = 100;
            String cevap;
            bool sonuc = false;

            Random randomSayi = new Random();
            int rndSayi = randomSayi.Next(min, max);

            do {
                Console.WriteLine(adim+".adım "+rndSayi);
                Console.Write("Doğrumu (E/H)");
                cevap = Console.ReadLine();
                if (cevap.Equals("E"))
                {
                    sonuc = true;
                }
                else if (cevap.Equals("H"))
                {
                    Console.Write("Yukarımı Aşşağımı (Y/A)");
                    cevap = Console.ReadLine();
                    if (cevap.Equals("Y"))
                    {
                        min = rndSayi;
                        rndSayi = randomSayi.Next(min, max);
                    }
                    else if (cevap.Equals("A")) {
                        max = rndSayi;
                        rndSayi = randomSayi.Next(min, max);
                    }
                }
                adim++;
            } while (!sonuc);
}
