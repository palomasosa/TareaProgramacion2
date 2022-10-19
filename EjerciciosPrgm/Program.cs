using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPrgm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SortedList
            //SortedList<string,string> diccionario = new SortedList<string,string>();
            //diccionario.Add("hello", "hola");
            //diccionario.Add("goodbye", "adios");
            //diccionario.Add("how're", "como estas");
            //diccionario.Add("you", "tu");
            //diccionario.Add("im", "yo estoy");
            //diccionario.Add("fine", "bien");
            //diccionario.Add("and", "y");
            //diccionario.Add("good", "bien");
            //diccionario.Add("bad", "mal");
            //diccionario.Add("why", "por que?");
            //diccionario.Add("thanks", "gracias");
            //diccionario.Add("for", "por");
            //diccionario.Add("asking", "preguntar");
            //diccionario.Add("had", "tuve");
            //diccionario.Add("a", "un");
            //diccionario.Add("day", "dia");

            //string frase = Console.ReadLine();

            //string[] subFrase = frase.Split(' ');

            //foreach (string s in subFrase)
            //{
            //    if (diccionario.ContainsKey(s))
            //    {
            //        Console.Write(diccionario[s] + ' ');
            //    }
            //}
            //Console.WriteLine();

            #endregion

            #region HashTable/Dictionary
            //Dictionary<string, string> diccionario = new Dictionary<string, string>();
            //diccionario.Add("hello", "hola");
            //diccionario.Add("goodbye", "adios");
            //diccionario.Add("how're", "como estas");
            //diccionario.Add("you", "tu");
            //diccionario.Add("im", "yo estoy");
            //diccionario.Add("fine", "bien");
            //diccionario.Add("and", "y");
            //diccionario.Add("good", "bien");
            //diccionario.Add("bad", "mal");
            //diccionario.Add("why", "por que?");
            //diccionario.Add("thanks", "gracias");
            //diccionario.Add("for", "por");
            //diccionario.Add("asking", "preguntar");
            //diccionario.Add("had", "tuve");
            //diccionario.Add("a", "un");
            //diccionario.Add("day", "dia");

            //string frase = Console.ReadLine();

            //string[] subFrase = frase.Split(' ');

            //foreach (string s in subFrase)
            //{
            //    if (diccionario.ContainsKey(s))
            //    {
            //        Console.Write(diccionario[s] + ' ');
            //    }
            //}
            //Console.WriteLine();

            #endregion

            #region HashSet/SortedSet
            SortedSet <string> SetPalabras = new SortedSet<string> ();
            string palabra = Console.ReadLine();   

            while (palabra != "")
            {
                if (SetPalabras.Contains(palabra))
                {
                    Console.WriteLine($"{palabra} ya está, ingrese otra palabra");
                    palabra = Console.ReadLine();
                }
                else
                {
                    SetPalabras.Add(palabra);
                    palabra = Console.ReadLine();
                }
            }

            #endregion
        }
    }
}
