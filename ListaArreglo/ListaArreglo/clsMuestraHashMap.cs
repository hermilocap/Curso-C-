using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaArreglo
{
    class clsMuestraHashMap
    {
        Hashtable Tabla;
        public clsMuestraHashMap()
        {
            Tabla = new Hashtable();
        }
        public void AgregarDatos()
        {
            Tabla.Add("0001","Producto 1");
            Tabla.Add("0121", "Producto 2");
            Tabla.Add("0132", "Producto 3");
            Tabla.Add("0243", "Producto 4");


        }

        public void Imprimir()
        {
            Console.WriteLine("Existe {0} elementos, dame la clave del producto: ");
            string cadena = Console.ReadLine();
            if (Tabla[cadena] == null)
                Console.WriteLine("El elemento no existe");
            else
            {
                Console.WriteLine("El elemento encontrado es: ");

                Console.WriteLine(Tabla[cadena]);
            }
                Console.ReadKey();

        }
        public void EliminarElementos(string key)
        {
            Tabla.Remove(key);
        }

    }

}
