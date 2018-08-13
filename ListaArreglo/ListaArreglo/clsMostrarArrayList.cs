using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaArreglo
{
    class clsMostrarArrayList
    {
        ArrayList lista;
        public clsMostrarArrayList()
        {
            lista = new ArrayList();
        }
        public void CapturarDatos() {
            string cadena;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Dame el dato {0}",i+1);
                cadena = Console.ReadLine();
                lista.Add(cadena);

            }
        }
        public void ImprimirDatos()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
