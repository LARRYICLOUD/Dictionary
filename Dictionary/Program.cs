using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES RECONOCIDO");
            //Dictionary se compone de un par clave-valor o key- value- pair
            Dictionary<string, int> empleados = new Dictionary<string, int>();
            //Añadiendo un key-value pair a la coleccion
            empleados.Add("Hugo", 36);
            empleados.Add("pedro", 27);

            foreach (KeyValuePair<string, int> elemento  in empleados)
            {
                /*Console.WriteLine(elemento.Key);
                Console.WriteLine(elemento.Value); puede realizarse la impresion de esta forma*/ 
                Console.WriteLine("Key = {0}, Value = {1}", elemento.Key, elemento.Value);
            }
        }
    }
}
