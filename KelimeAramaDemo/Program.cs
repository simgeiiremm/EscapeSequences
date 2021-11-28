using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeAramaDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle: ");
            string cumle = Console.ReadLine();
            Console.Write("Kelime: ");
            string kelime = Console.ReadLine();
            string sonuc;
            //if (cumle.IndexOf(kelime) == -1)
            //    sonuc = "\"" + cumle + "\" içerisinde  \"" + kelime + "\" bulunamadı.";
            //else
            //    sonuc = "\"" + cumle + "\" içerisinde  \"" + kelime + "\" bulundu.";
            //Console.WriteLine(sonuc);

            //split paramsdır. içerisine karakterleri tek tek atamamıza gerek yok. 
            //Aşağıdaki örnegi yapmamıza gerek yok!
            // char[] kelime = cumle.Split({ ' '});


            string[] cumleKelimeleri = cumle.Split(' ');
            bool bulundu = false; //flag
            foreach(string cumleKelime in cumleKelimeleri)
            {
                if (cumleKelime.Trim()== kelime.Trim()) 
                {
                    bulundu = true;
                    break;
                }
            }
            if (bulundu == true)
            {
                sonuc = "\"" + cumle + "\" içerisinde  \"" + kelime + "\" bulundu.";
            }
            else
            {
                sonuc = "\"" + cumle + "\" içerisinde  \"" + kelime + "\" bulunamadı.";                
            }
            Console.WriteLine(sonuc);
            Console.ReadLine();












            Console.ReadLine();
        }
    }
}
