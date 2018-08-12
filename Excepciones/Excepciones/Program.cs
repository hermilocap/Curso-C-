using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseAbstracta;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //clase abstracta no se puede instanciar
            clsClientesBase cliente = new clsClienteContactos(0, "hermilo", "001", "sabh", 1, "hermilo santiago", "222", "55666", "hermilocap@gmail.com", "apatzingan", "3", "3", "lazaro cardenas", "cuernavaca", "Mexico", "620");

            //polimorfismo: permite tranferir de la jerarquia de una clase
            inSalida Impresion;
            string cadena = Console.ReadLine();
            if (cadena == "1")
                Impresion = new clsImpresion();
            else
                Impresion = new clsArchivos();
            //Impresion.imprimirCliente(cliente);
            try
            {
                Impresion.imprimirCliente(cliente);
            }
            catch (Exception e)
            {
                Console.WriteLine("ocurrió un error" + e.Message);
                Console.ReadKey();
            }

            //impresion = new clsImpresion();
            //impresion.imprimirCliente(cliente);
            //interfaz: definir un comportamiento común

        }
    }
}
