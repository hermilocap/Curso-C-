using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesVentas cliente;
            cliente = new clsClientesVentas();
            cliente.IdCliente = 122;
            cliente.Apellido = "sANTIAGO";
            cliente.Nombre = "hERMILO";
            cliente.RFC = "SABH";
            cliente.Direccion = "Calle apatzingan";
            cliente.Colonia = "lazaro cardenas";
            cliente.Municipio = "cuerna";
            cliente.EsCredito = true;
            Console.WriteLine(cliente.Apellido+" "+cliente.Nombre);
            Console.ReadKey();
        }
    }
}
