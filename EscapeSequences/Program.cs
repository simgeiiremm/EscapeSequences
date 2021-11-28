using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeSequences{

    class Program
    {
        static void Main(string[] args)
        {
            //escape sequences 
            string name = "ÇAğıl";
            string escapeName = "\"Çağıl\""; //"Çağıl"
            Console.WriteLine(escapeName);
            String surname = "Alşaç";
            escapeName = name + "\n" + surname;
            Console.WriteLine(escapeName);
            escapeName = name + "\t" + surname;
            Console.WriteLine(escapeName);

            string path1 = "C:\\BA\\Console"; //C:\BA\Console
            path1 = @"C:\BA\Console"; //C:\BA\Console


            






            Console.ReadLine();
        }
    }
}
