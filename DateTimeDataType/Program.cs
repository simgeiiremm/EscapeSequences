using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime simdi = DateTime.Now; //tarih ve saati alır datetime ın içerisine atar
            Console.WriteLine(simdi);
            Console.WriteLine(simdi.ToShortDateString()); //28.11.2021
            Console.WriteLine(simdi.ToLongDateString()); //28 Kasım 2021 Pazar
            Console.WriteLine(simdi.ToShortTimeString()); //saniyeyi göstermez
            Console.WriteLine(simdi.ToLongTimeString,()); //saniyeyi gösterir
            Console.WriteLine(simdi.Month + "/" + simdi.Day + "/" + simdi.Year + " " + simdi.Hour + ":" + simdi.Minute + ":" + simdi.Second + ".");

            DateTime tarih = new DateTime(2020, 11, 28, 19, 17, 0);
            Console.WriteLine(tarih);
            Console.ReadLine();
        }
    }
}
