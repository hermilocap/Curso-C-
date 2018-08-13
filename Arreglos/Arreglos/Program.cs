using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arreglo = new int[12];
            int i;
            for (i = 0; i <Arreglo.Length; i++)
            {
                string cadena = Console.ReadLine();
                Arreglo[i] = Convert.ToInt32(cadena);

               // Arreglo[i] =i+1;
            }

            for (i = 0; i < Arreglo.Length; i++)
            {
                Console.WriteLine("{0}",Arreglo[i]);
            }

            Console.ReadKey();
        }
    }
}
