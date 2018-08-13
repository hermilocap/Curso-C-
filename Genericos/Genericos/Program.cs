using ClaseAbstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            List<clsClientesBase> clientes;
            clientes = new List<clsClientesBase>();

            while(opcion!="s")
            {
                Console.WriteLine("Opciones");
                Console.WriteLine("a. Agregar a la lista");
                Console.WriteLine("b. Quitar de la lista");
                Console.WriteLine("c. Imprimir lista");
                Console.WriteLine();
                Console.WriteLine("s. Salir");
                opcion = Console.ReadLine();
                if (opcion == "a")
                {
                    string cadena = Console.ReadLine();
                    clsClientesBase cliente = new clsClientesBase();
                    cliente.Id = clientes.Count + 1;
                    cliente.Nombre = cadena;
                    clientes.Add(cliente);
                }
                else if (opcion == "b")
                {
                    string cadena = Console.ReadLine();
                    clientes.RemoveAt(Convert.ToInt32(cadena));

                }
                else if(opcion=="c") {
                    foreach (clsClientesBase item in clientes)
                    {
                        Console.WriteLine("Los datos del cliente son");
                        Console.WriteLine(item.Id.ToString()+" "+item.Nombre);
                    }
                }

                }
            }
        }
    }

