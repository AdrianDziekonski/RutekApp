using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.VisualBasic;

namespace RutekApp
{
    class RutekApp
    {

        public static List<string> Split(string input)
        {
            var result = new List<string>();
            var index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ',')
                {
                    var word = input.Substring(index, i - index);
                    result.Add(word);
                    index = i + 1;
                }
                else if (i == input.Length - 1)
                {
                    var word = input.Substring(index, input.Length - index);
                    result.Add(word);
                }

            }


            return result;
        }

        public List<string> WriteTheSame(string input)
        {
            var resultat = new List<string>();
            var indexik = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[i++])
                {
                    var same = input.Substring(indexik, i - indexik);
                    resultat.Add(same);
                    indexik = i + 1;    
                }
                else if (i == input.Length - 1)
                {
                    var word = input.Substring(indexik, input.Length - indexik);
                    resultat.Add(word);
                }
            }
            return resultat;
        }
        public static void wyświetlListe(List<string> list)
        {
            int l=list.Count;
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public static void wyświetlListeInt(List<int> list)
        {
            int l = list.Count;
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

       

        public static void quickSort(List<int> list, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = list[(left + right) / 2];
            while (i < j)
            {
                while (list[i] < pivot) i++;
                while (list[j] > pivot) j--;
                if (i <= j)
                {
                    // swap
                    var tmp = list[i];
                    list[i++] = list[j];  
                    list[j--] = tmp;
                }
            }
            if (left < j) quickSort(list, left, j);
            if (i < right) quickSort(list, i, right);
            //wyświetlListeInt(list);
        }

        public static void zapiszListeDoPliku(List<int>list)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"g:\Praca\IT\C#\RutekApp\liczby_posortowane.txt");
            for (int i = 0; i < list.Count; i++)
            {
                file.WriteLine(list[i]);
            }
            file.Close();
        }
    }
}

