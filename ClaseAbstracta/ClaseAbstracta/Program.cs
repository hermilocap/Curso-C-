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
            clsClientesBase cliente = new clsClientesBase(0,"hermilo","001","sabh",1,"hermilo santiago");
            Console.WriteLine(cliente.Clave+" "+cliente.Nombre);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.RFC);
           
            Console.ReadKey();
        }
    }
}
