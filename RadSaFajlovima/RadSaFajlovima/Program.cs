using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadSaFajlovima
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //ispisivanje celog fajla linije po linije

            string file = @"E:\VSprojekti\RadSaFajlovima\RadSaFajlovima\file.txt";
            using (StreamReader sr = new StreamReader(file))
            {
                string linija = null;
                while ((linija = sr.ReadLine()) != null)
                {
                    Console.WriteLine(linija);
                }
            }

            Console.WriteLine("\n2.test\n");

            //ispisuje sve u jednom redu sve jedno pored drugog

            using (StreamReader sr = new StreamReader(file))
            {
                StringBuilder sb = new StringBuilder();
                string linija = null;
                while ((linija = sr.ReadLine()) != null)
                {
                    sb.Append(linija.Trim());
                }

                Console.WriteLine(sb.ToString());
            }

            Console.WriteLine("\n3.test\n");

            //svaka linija u poseban red(bas sadrzaj fajla) - splitovanje po redu

            using (StreamReader sr = new StreamReader(file))
            {
                StringBuilder sb = new StringBuilder();
                string linija = null;
                while ((linija = sr.ReadLine()) != null)
                {
                    sb.AppendLine(linija);
                }

                Console.WriteLine(sb.ToString());
            }



            Console.ReadLine();
        }
    }
}
