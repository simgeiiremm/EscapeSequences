using System;
using System.Collections.Generic;
using System.Globalization;
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
            Console.WriteLine(simdi.ToLongTimeString()); //saniyeyi gösterir
            Console.WriteLine(simdi.Month + "/" + simdi.Day + "/" + simdi.Year + " " + simdi.Hour + ":" + simdi.Minute + ":" + simdi.Second + ".");

            DateTime tarih = new DateTime(2020, 11, 28, 19, 17, 0); //datetime = struct adı verilir 
            Console.WriteLine(tarih);

            tarih = DateTime.Parse("04.12.2021", new CultureInfo("tr"));
            Console.WriteLine(tarih);
            tarih = DateTime.Parse("04/13/2021 16:01:25", new CultureInfo("en"));

            //Console.WriteLine(tarih.ToString(new CultureInfo("en")));
            string tarihText = tarih.ToString(new CultureInfo("en"));
            Console.WriteLine(tarihText);
            tarihText = tarih.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(tarihText);

            simdi = DateTime.Now;
            Console.WriteLine("Yarın: " + simdi.AddDays(1));
            Console.WriteLine("1 hafta öncesi: " + simdi.AddDays(-7));
            Console.WriteLine("6 ay sonrası: " + simdi.AddMonths(6).ToShortDateString());
            Console.WriteLine("2 sene sonrası: " + simdi.AddYears(7).ToLongDateString());
            Console.WriteLine("12 saat sonrası: " + simdi.AddHours(12));
            Console.WriteLine("Yarım saat öncesi: " + simdi.AddMinutes(-30));

            var tarih1 = DateTime.Parse("01.10.2020");
            var tarih2 = DateTime.Parse("20.10.2020");
            if (tarih2.CompareTo(tarih1) > 0)
                Console.WriteLine("tarih2 > tarih1");
            else if (tarih2.CompareTo(tarih1) < 0)
                Console.WriteLine("tarih2 < tarih1");
            else
                Console.WriteLine("tarih2 = tarih1");

            if (tarih2 > tarih1)
                Console.WriteLine("tarih2 > tarih1");
            else if (tarih2 < tarih1)
                Console.WriteLine("tarih2 < tarih1");
            else //tarih2 == tarih1
                Console.WriteLine("tarih2 = tarih1");

            Console.WriteLine(simdi.Date);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(simdi.DayOfWeek + " " + (int)simdi.DayOfWeek);
            Console.WriteLine(simdi.DayOfYear);
            Console.WriteLine();

            Console.WriteLine("PI: " + Math.PI);
            int sayi1 = 10;
            int sayi2 = 20;
            Console.WriteLine("Sonuc: " + (sayi1 - sayi2) + ", Mutlak değer: " + Math.Abs(sayi1 - sayi2));

            double sayi = 2.9;
            Console.WriteLine((int)sayi); //2
            Console.WriteLine(Math.Floor(sayi)); //2
            Console.WriteLine(Math.Ceiling(sayi)); //3
            Console.WriteLine(Math.Pow(2, 4)); //16
            Console.WriteLine(Math.Min(1, 2) + " - " + Math.Max(1.1, 2.2));
            double sayi4 = 12.345;
            double sayi5 = 98.765;
            Console.WriteLine(Math.Round(sayi4));
            Console.WriteLine(Math.Round(sayi5));
            Console.WriteLine(Math.Round(sayi4, 1));
            Console.WriteLine(Math.Round(sayi5, 1));
            Console.WriteLine(Math.Round(sayi4, 2));
            Console.WriteLine(Math.Round(sayi5, 2));
            Console.WriteLine(Math.Sqrt(64)); //8
            // 8 ^(1/3) = 2
            Console.WriteLine(Math.Pow(8, 1.0/3.0));









            Console.ReadLine();
        }
    }
}
