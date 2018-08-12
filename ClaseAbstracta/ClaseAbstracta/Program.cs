using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            //clase abstracta no se puede instanciar
            clsClientesBase cliente = new clsClienteContactos(0,"hermilo","001","sabh",1,"hermilo santiago","222","55666","hermilocap@gmail.com","apatzingan","3","3","lazaro cardenas","cuernavaca","Mexico","620");

            //polimorfismo: permite tranferir de la jerarquia de una clase
            clsImpresion impresion;
            impresion = new clsImpresion();
            impresion.imprimirCliente(cliente);
            //interfaz: definir un comportamiento común


           
        }
    }
}
