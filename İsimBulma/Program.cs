using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İsimBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[5]
            {
                "Robert DeNiro",
                "Jennifer Lopez",
                "Robert Downey Jr.",
                "Al Pacino",
                "Kate Beckinsale"
            };
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            //2nd way:
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            //3rd way
            //int j = 0;
            //while (j < isimler.Length)
            //{
            //    Console.WriteLine(isimler[j]);
            //    j++;
            //}    
            Console.Write("İsim: ");
            string giris = Console.ReadLine();
            bool bulundu = false;
            foreach (var isim in isimler)
            {
                if (isim.ToUpper().Contains(giris.ToUpper()))
                {
                    bulundu = true;
                    break;
                }
            }   
            if(bulundu)
            {
                Console.WriteLine(giris + " bulundu.");
            }
            else
            {
                Console.WriteLine(giris + "bulunamadı.");
            }
            Console.ReadLine();

        }
    }
}
