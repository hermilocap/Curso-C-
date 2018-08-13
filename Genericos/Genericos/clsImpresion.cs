using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
  public  class clsImpresion
    {
        public void imprimirCliente(clsAbsCliente cliente) {
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.RFC);
            Console.ReadKey();
        }

        public void imprimirDireccion(clsClientesDireccion Direccion)
        {
            Console.WriteLine(Direccion.Calle + " " + Direccion.NumeroExterior+" "+Direccion.NumeroInterior);
            Console.WriteLine(Direccion.Colonia);
            Console.WriteLine(Direccion.CP);
            Console.WriteLine(Direccion.Estado);
            Console.ReadKey();
        }
    }
}
