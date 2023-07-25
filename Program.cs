using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;

namespace RutekApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"g:\Praca\IT\C#\RutekApp\liczby_nieposortowane.txt";
            string pathAfterWork = @"g:\Praca\IT\C#\RutekApp\liczby_posortowane.txt";
            
            
            string nieposortowaneString = File.ReadAllText(path);
            Console.WriteLine("Nieposortowane liczby: "+ nieposortowaneString);

            List<string> splitString;

            splitString=RutekApp.Split(nieposortowaneString);

            Console.WriteLine("podzielony string: ");
            RutekApp.wyświetlListe(splitString);

            //List<int> nieposortowaneInty;
            Console.WriteLine("stringi zamienienione w inty: ");
            List<int> nieposortowaneInty =splitString.ConvertAll(s => Int32.Parse(s));
            

            var sum = nieposortowaneInty[0] + 2;        //sprawdzenie czy przekonwertowało na int
            Console.WriteLine("suma: "+sum);

            
            Console.WriteLine("Quick sort: ");
            RutekApp.quickSort(nieposortowaneInty,0,nieposortowaneInty.Count-1);
            RutekApp.wyświetlListeInt(nieposortowaneInty);


            RutekApp.zapiszListeDoPliku(nieposortowaneInty);


            
        }
    }
}